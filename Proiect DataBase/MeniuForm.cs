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
    public partial class MeniuForm : Form
    {
        public MeniuForm()
        {
            InitializeComponent();
        }

        private void StudentiLBL_Click(object sender, EventArgs e)
        {
            StudentiForm f = new StudentiForm();
            f.Show();
            this.Hide();

        }

        private void ProfesoriLBL_Click(object sender, EventArgs e)
        {
            ProfesoriForm p = new ProfesoriForm();
            p.Show();
            this.Hide();
        }

        private void activitatiLBL_Click(object sender, EventArgs e)
        {
            ActivitatiForm a = new ActivitatiForm();
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ParticipareForm c = new ParticipareForm();
            c.Show();
            this.Hide();
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CoordonatoriForm c = new CoordonatoriForm();
            c.Show();
            this.Hide();
        }
    }
}
