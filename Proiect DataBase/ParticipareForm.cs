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
    public partial class ParticipareForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareParticipare stocareParticipari = (IStocareParticipare)new StocareFacultate().GetTipStocare(typeof(Participare));
        IStocareStudenti stocareStudenti = (IStocareStudenti)new StocareFacultate().GetTipStocare(typeof(Studenti));
        IStocareActivitati stocareActivitati = (IStocareActivitati)new StocareFacultate().GetTipStocare(typeof(Activitati));

        public ParticipareForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idParticipare = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            if ( idParticipare!= null)
            {

                try
                {
                    Participare p = stocareParticipari.GetParticipare(Int32.Parse(idParticipare));
                    if (p != null)
                    {
                        IDParticipare.Text = p.IdParticipare.ToString();
                        comboBoxActiv.SelectedItem = new ComboItem(p.Activitati.Denumire, p.IdActivitate);
                        comboBoxStud.SelectedItem = new ComboItem(p.Studenti.Nume, p.IdStudent);
                        Int32.Parse(IDParticipare.Text);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                // Tratați cazul în care celula nu conține o valoare validă
            }
            
          
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
        private void IncarcaStudenti()
        {
            
            try
            {
                comboBoxStud.Items.Clear();
                var studenti = stocareStudenti.GetStudenti();
                if (studenti != null && studenti.Any())
                {
                    foreach (var s in studenti)
                    {
                        comboBoxStud.Items.Add(new ComboItem(s.Nume, (Int32)s.IdStudent));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void AfiseazaCatalog()
        {
            try
            {
                var participare = stocareParticipari.GetParticipari();
                if (participare != null && participare.Any())
                {
                    dataGridView1.DataSource = participare.Select(s => new { s.IdParticipare, s.IdActivitate, s.IdStudent }).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void Afiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaCatalog();
        }

        private void ActualizeazaBtn_Click(object sender, EventArgs e)
        {
            int idParticipare;
            if (int.TryParse(IDParticipare.Text, out idParticipare))
            {

            }
            else
            {
                MessageBox.Show("ID participare invalid");
            }
            try
            {

                var participare = new Participare(

                ((ComboItem)comboBoxActiv.SelectedItem).Value,
                ((ComboItem)comboBoxStud.SelectedItem).Value,

                Int32.Parse(IDParticipare.Text));

                var rezultat = stocareParticipari.UpdateParticipare(participare);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idParticipare = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            bool rezultat = stocareParticipari.DeleteParticipare(Int32.Parse(idParticipare));
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

        private void ParticipareForm_Load(object sender, EventArgs e)
        {
            IncarcaActivitati();
            IncarcaStudenti();
        }

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var participare = new Participare(
                     ((ComboItem)comboBoxActiv.SelectedItem).Value,
                     ((ComboItem)comboBoxStud.SelectedItem).Value
                );


                var rezultat = stocareParticipari.AddParticipare(participare);

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
    }
}