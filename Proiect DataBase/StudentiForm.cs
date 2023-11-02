using InterfataUtilizator;

using LibrarieModele;


using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_DataBase
{
    public partial class StudentiForm : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

     

        IStocareStudenti stocareStudenti = (IStocareStudenti)new StocareFacultate().GetTipStocare(typeof(Studenti));
        public StudentiForm()
        {
            InitializeComponent();
            if (stocareStudenti == null)
            { MessageBox.Show("Eroare la initializare"); }
        }


        private void dataGridStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridStudenti.CurrentCell.RowIndex;
            string idStudent = dataGridStudenti[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Studenti s = stocareStudenti.GetStudent(Int32.Parse(idStudent));
                if(s!=null)
                { IDLbl.Text = s.IdStudent.ToString();
                    NumeTextBox.Text = s.Nume;
                    PrenumeTextBox.Text = s.Prenume;
                    comboFacultate.SelectedItem = s.Facultate;
                    comboSpecializari.SelectedItem = s.Specializare;
                    AnTextBox.Text = s.AnStudiu.ToString();
                    CNPTextBox.Text = s.CNP;
                    EmailTextBox.Text = s.Email;
                    TelefonTextBox.Text = s.Telefon;
                    AdresaTextBox.Text = s.Adresa;
                    Int32.Parse(IDLbl.Text);
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
                var studenti = stocareStudenti.GetStudenti();
                if (studenti != null && studenti.Any())
                {
                    dataGridStudenti.DataSource = studenti.Select(s => new { s.IdStudent, s.Nume, s.Prenume, s.Facultate, s.Specializare, s.AnStudiu, s.CNP, s.Email, s.Telefon, s.Adresa }).ToList();


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

        private void comboFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboFacultate.SelectedItem.ToString().Equals("FEAA"))
            {
                comboSpecializari.Items.Clear();
                comboSpecializari.Items.Add("Management");
                comboSpecializari.Items.Add("Afaceri Internaționale");
                comboSpecializari.Items.Add("Informatică economică");

            }
            else if (comboFacultate.SelectedItem.ToString().Equals("FIESC"))
            {
                comboSpecializari.Items.Clear();
                comboSpecializari.Items.Add("Calculatoare");
                comboSpecializari.Items.Add("Electronică aplicată");
                comboSpecializari.Items.Add("Echipamente și sisteme medicale");
                comboSpecializari.Items.Add("AIA");

            }
            else if (comboFacultate.SelectedItem.ToString().Equals("FIG"))
            {
                comboSpecializari.Items.Clear();
                comboSpecializari.Items.Add("Istorie");
                comboSpecializari.Items.Add("Geografie");
                comboSpecializari.Items.Add("Aaa");

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MeniuForm f = new MeniuForm();
            f.Show();
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizeazaBtn_Click(object sender, EventArgs e)
        {
            int idStudent;
            if (int.TryParse(IDLbl.Text, out idStudent))
            {
                // Conversia a reușit, idStudent conține valoarea numerică
                // Poți continua cu adăugarea sau actualizarea studentului folosind idStudent
            }
            else
            {
                // Conversia a eșuat, IDLbl.Text nu conține o valoare numerică validă
                // Poți afișa un mesaj de eroare sau poți executa o acțiune corespunzătoare
                MessageBox.Show("ID student invalid");
            }
            try
            {
                var student = new Studenti(
                    NumeTextBox.Text,
                    PrenumeTextBox.Text,
                    comboFacultate.SelectedItem.ToString(),
                    comboSpecializari.SelectedItem.ToString(),
                    Int32.Parse(AnTextBox.Text),
                    CNPTextBox.Text,
                    EmailTextBox.Text,
                    TelefonTextBox.Text,
                    AdresaTextBox.Text,
                    Int32.Parse(IDLbl.Text));
               
                    var rezultat = stocareStudenti.UpdateStudent(student);
                 
                    if (rezultat == SUCCES)
                    {
                        MessageBox.Show("Student actualizat");
                        AfiseazaCatalog();
                    }
                    else
                { MessageBox.Show("Eroare la actualizarea studentului"); }
             
            }
                catch (Exception ex)
                    {
                    MessageBox.Show("Exceptie"+ex.Message);
                }
        }

        private void AdaugaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Studenti(
                    NumeTextBox.Text,
                    PrenumeTextBox.Text,
                    comboFacultate.SelectedItem.ToString(),
                    comboSpecializari.SelectedItem.ToString(),
                    Int32.Parse(AnTextBox.Text),
                    CNPTextBox.Text,
                    EmailTextBox.Text,
                    TelefonTextBox.Text,
                    AdresaTextBox.Text
                );

               
                var rezultat = stocareStudenti.AddStudent(student);

                  if(rezultat==true)
                    {
                        AfiseazaCatalog();
                    }
                    else { MessageBox.Show("Studentul nu a putut fi adaugat"); }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }
        }

        private void StergeBtn_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridStudenti.CurrentCell.RowIndex;
            string idProfesor = dataGridStudenti[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            bool rezultat = stocareStudenti.DeleteStudent(Int32.Parse(idProfesor));
            if (rezultat)
            {
                MessageBox.Show("Student sters");
                AfiseazaCatalog();
            }
            else
            {
                MessageBox.Show("Eroare la stergere");
            }
        }
    }
}


