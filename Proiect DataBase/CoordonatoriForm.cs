using InterfataUtilizator;
using LibrarieModele;

using ManagementStudenti;

using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_DataBase
{
    public partial class CoordonatoriForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareCoordonare stocareCoordonari = (IStocareCoordonare)new StocareFacultate().GetTipStocare(typeof(Coordonare));
        IStocareActivitati stocareActivitati = (IStocareActivitati)new StocareFacultate().GetTipStocare(typeof(Activitati));
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFacultate().GetTipStocare(typeof(Profesori));

        public CoordonatoriForm()
        {
            InitializeComponent();
        }
        private void IncarcaActivitati()
        {
            try
            {
                comboBoxActiv.Items.Clear();
                var activitati = stocareActivitati.GetActivitati();
                if (activitati != null && activitati.Any())
                {
                    foreach (var activitate in activitati)
                    {
                        comboBoxActiv.Items.Add(new ComboItem(activitate.Denumire, (Int32)activitate.IdActivitate));


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void IncarcaProfesori()
        {

            try
            {
                comboBoxProf.Items.Clear();
                var profesori = stocareProfesori.GetProfesori();
                if (profesori != null && profesori.Any())
                {
                    foreach (var s in profesori)
                    {
                        comboBoxProf.Items.Add(new ComboItem(s.Nume, (Int32)s.IdProfesor));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeniuForm f = new MeniuForm();
            f.Show();
            this.Close();
        }
        private void AfiseazaCatalog()
        {
            try
            {
                var participare = stocareCoordonari.GetCoordonari();
                if (participare != null && participare.Any())
                {
                    dataGridView1.DataSource = participare.Select(s => new { s.IdCoordonare, s.IdActivitate, s.IdProfesor }).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
      
        private void StergeBtn_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idCoordonare = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            bool rezultat = stocareCoordonari.DeleteCoordonare(Int32.Parse(idCoordonare));
            if (rezultat)
            {
                MessageBox.Show("Studentul nu mai participa la activitate");
                AfiseazaCatalog();
            }
            else
            {
                MessageBox.Show("Eroare la stergere");
            }
        }

        private void Afiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaCatalog();
        }

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var coordonare = new Coordonare(
                     ((ComboItem)comboBoxActiv.SelectedItem).Value,
                     ((ComboItem)comboBoxProf.SelectedItem).Value
                );


                var rezultat = stocareCoordonari.AddCoordonare(coordonare);

                if (rezultat == true)
                {
                    AfiseazaCatalog();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }
        
    }

        private void ActualizeazaBtn_Click(object sender, EventArgs e)
        {
            int idCoordonare;
            if (int.TryParse(IDCoordonare.Text, out idCoordonare))
            {

            }
            else
            {
                MessageBox.Show("ID participare invalid");
            }
            try
            {

                var coordonare = new Coordonare(

                ((ComboItem)comboBoxActiv.SelectedItem).Value,
                ((ComboItem)comboBoxProf.SelectedItem).Value,

                Int32.Parse(IDCoordonare.Text));

                var rezultat = stocareCoordonari.UpdateCoordonare(coordonare);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void CoordonatoriForm_Load(object sender, EventArgs e)
        {
            IncarcaActivitati();
            IncarcaProfesori();
        }
    }
}
