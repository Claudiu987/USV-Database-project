using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InterfataUtilizator;

using LibrarieModele;

using NivelAccesDate;

namespace Proiect_DataBase
{
    public partial class ActivitatiForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;



       IStocareActivitati stocareActivitati= (IStocareActivitati)new StocareFacultate().GetTipStocare(typeof(Activitati));

        public ActivitatiForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idActivitate = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Activitati a = stocareActivitati.GetActivitate(Int32.Parse(idActivitate));
                if (a != null)
                {
                    LblID.Text = a.IdActivitate.ToString();
                    DenumireTextBox.Text = a.Denumire;
                    DescriereTextBox.Text = a.Descriere;
                    dateTimePicker1.Text = a.Data_Inceput.ToShortDateString();
                    dateTimePicker2.Text = a.Data_Sfarsit.ToShortDateString();
                    Int32.Parse(LblID.Text);
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
                var activitati = stocareActivitati.GetActivitati();
                if (activitati != null && activitati.Any())
                {
                    dataGridView1.DataSource = activitati.Select(a => new { a.IdActivitate, a.Denumire, a.Descriere, a.Data_Inceput,a.Data_Sfarsit }).ToList();


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

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var activitate = new Activitati(
                    DenumireTextBox.Text,
                    DescriereTextBox.Text,
                    Convert.ToDateTime(dateTimePicker1.Text),
                    Convert.ToDateTime(dateTimePicker2.Text)
                    
                );


                var rezultat = stocareActivitati.AddActivitate(activitate);

                if (rezultat == true)
                {
                    AfiseazaCatalog();
                }
                else { MessageBox.Show("Activitatea nu a putut fi adaugata"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }
        }

        private void ActualizeazaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var activitate = new Activitati(
                    DenumireTextBox.Text,
                    DescriereTextBox.Text,
                    Convert.ToDateTime(dateTimePicker1.Text),
                    Convert.ToDateTime(dateTimePicker2.Text),
                    Int32.Parse(LblID.Text)

                ) ;


                var rezultat = stocareActivitati.UpdateActivitate(activitate);

                if (rezultat == true)
                {
                    AfiseazaCatalog();
                }
                else { MessageBox.Show("Activitatea nu a putut fi actualizata"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            string idActivitate = dataGridView1[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            bool rezultat = stocareActivitati.DeleteActivitate(Int32.Parse(idActivitate));
            if (rezultat)
            {
                MessageBox.Show("Activitate stearsa");
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
    }
}

