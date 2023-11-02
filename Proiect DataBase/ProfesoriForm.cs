using InterfataUtilizator;

using LibrarieModele;

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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_DataBase
{
    public partial class ProfesoriForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;
        IStocareProfesori stocareProfesori = (IStocareProfesori)new StocareFacultate().GetTipStocare(typeof(Profesori));
        public ProfesoriForm()
        {
            InitializeComponent();
            if (stocareProfesori == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }



        private void AfiseazaCatalog()
        {
            try
            {
                var profesori = stocareProfesori.GetProfesori();
                if (profesori != null && profesori.Any())
                {
                    dataGridViewProfesori.DataSource = profesori.Select(p => new { p.IdProfesor, p.Nume, p.Prenume, p.Titlu, p.Email, p.Telefon }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void ActualizeazaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var profesor = new Profesori(
                    NumeTextBox.Text,
                    PrenumeTextBox.Text,

                    TitluTextBox.Text,
                    EmailTextBox.Text,
                    TelefonTextBox.Text,

                    Int32.Parse(LblID.Text));

                var rezultat = stocareProfesori.UpdateProfesor(profesor);

                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Profesor  actualizat");
                    AfiseazaCatalog();
                }
                else
                { MessageBox.Show("Eroare la actualizarea profesorului"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var profesor = new Profesori(
                    NumeTextBox.Text,
                    PrenumeTextBox.Text,
                    TitluTextBox.Text,
                    EmailTextBox.Text,
                    TelefonTextBox.Text);



                var rezultat = stocareProfesori.AddProfesor(profesor);

                if (rezultat == true)
                {
                    AfiseazaCatalog();
                }
                else { MessageBox.Show("Profesorul nu a putut fi adaugat"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }
        }

        private void MinusBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProfesori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridViewProfesori.CurrentCell.RowIndex;
            string idProfesor = dataGridViewProfesori[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Profesori p = stocareProfesori.GetProfesor(Int32.Parse(idProfesor));
                if (p != null)
                {
                    LblID.Text = p.IdProfesor.ToString();
                    NumeTextBox.Text = p.Nume;
                    PrenumeTextBox.Text = p.Prenume;
                    TitluTextBox.Text = p.Titlu;
                    EmailTextBox.Text = p.Email;
                    TelefonTextBox.Text = p.Telefon;
                    Int32.Parse(LblID.Text);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AfisareBtn_Click(object sender, EventArgs e)
        {
            AfiseazaCatalog();
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridViewProfesori.CurrentCell.RowIndex;
            string idProfesor = dataGridViewProfesori[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            bool rezultat = stocareProfesori.DeleteProfesor(Int32.Parse(idProfesor));
            if (rezultat )
            {
                MessageBox.Show("Profesor sters");
                AfiseazaCatalog();
            }
            else
            {
                MessageBox.Show("Eroare la stergere");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeniuForm f = new MeniuForm();
            f.Show();
            this.Close();
        }
    }
}
