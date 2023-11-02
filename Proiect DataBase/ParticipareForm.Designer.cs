namespace Proiect_DataBase
{
    partial class ParticipareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ActualizeazaBtn = new System.Windows.Forms.Button();
            this.Afiseaza = new System.Windows.Forms.Button();
            this.StergeBtn = new System.Windows.Forms.Button();
            this.AdaugaBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxActiv = new System.Windows.Forms.ComboBox();
            this.comboBoxStud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDParticipare = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MinusBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 53);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARTICIPARE";
            // 
            // MinusBtn
            // 
            this.MinusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.MinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.ForeColor = System.Drawing.Color.Crimson;
            this.MinusBtn.Location = new System.Drawing.Point(736, 15);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(24, 23);
            this.MinusBtn.TabIndex = 2;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Crimson;
            this.CloseBtn.Location = new System.Drawing.Point(766, 15);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ActualizeazaBtn);
            this.panel2.Controls.Add(this.Afiseaza);
            this.panel2.Controls.Add(this.StergeBtn);
            this.panel2.Controls.Add(this.AdaugaBtn);
            this.panel2.Location = new System.Drawing.Point(-2, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 407);
            this.panel2.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(58, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActualizeazaBtn
            // 
            this.ActualizeazaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ActualizeazaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizeazaBtn.FlatAppearance.BorderSize = 0;
            this.ActualizeazaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizeazaBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ActualizeazaBtn.Location = new System.Drawing.Point(14, 115);
            this.ActualizeazaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ActualizeazaBtn.Name = "ActualizeazaBtn";
            this.ActualizeazaBtn.Size = new System.Drawing.Size(155, 26);
            this.ActualizeazaBtn.TabIndex = 23;
            this.ActualizeazaBtn.Text = "ACTUALIZEAZA";
            this.ActualizeazaBtn.UseVisualStyleBackColor = false;
            this.ActualizeazaBtn.Click += new System.EventHandler(this.ActualizeazaBtn_Click);
            // 
            // Afiseaza
            // 
            this.Afiseaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.Afiseaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Afiseaza.FlatAppearance.BorderSize = 0;
            this.Afiseaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afiseaza.ForeColor = System.Drawing.Color.Crimson;
            this.Afiseaza.Location = new System.Drawing.Point(14, 31);
            this.Afiseaza.Margin = new System.Windows.Forms.Padding(0);
            this.Afiseaza.Name = "Afiseaza";
            this.Afiseaza.Size = new System.Drawing.Size(155, 28);
            this.Afiseaza.TabIndex = 1;
            this.Afiseaza.Text = "AFISEAZA";
            this.Afiseaza.UseVisualStyleBackColor = false;
            this.Afiseaza.Click += new System.EventHandler(this.Afiseaza_Click);
            // 
            // StergeBtn
            // 
            this.StergeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.StergeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StergeBtn.FlatAppearance.BorderSize = 0;
            this.StergeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StergeBtn.ForeColor = System.Drawing.Color.Crimson;
            this.StergeBtn.Location = new System.Drawing.Point(14, 154);
            this.StergeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StergeBtn.Name = "StergeBtn";
            this.StergeBtn.Size = new System.Drawing.Size(155, 27);
            this.StergeBtn.TabIndex = 25;
            this.StergeBtn.Text = "STERGE";
            this.StergeBtn.UseVisualStyleBackColor = false;
            this.StergeBtn.Click += new System.EventHandler(this.StergeBtn_Click);
            // 
            // AdaugaBtn
            // 
            this.AdaugaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.AdaugaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdaugaBtn.FlatAppearance.BorderSize = 0;
            this.AdaugaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdaugaBtn.ForeColor = System.Drawing.Color.Crimson;
            this.AdaugaBtn.Location = new System.Drawing.Point(14, 74);
            this.AdaugaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AdaugaBtn.Name = "AdaugaBtn";
            this.AdaugaBtn.Size = new System.Drawing.Size(155, 28);
            this.AdaugaBtn.TabIndex = 22;
            this.AdaugaBtn.Text = "ADAUGA";
            this.AdaugaBtn.UseVisualStyleBackColor = false;
            this.AdaugaBtn.Click += new System.EventHandler(this.AdaugaBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Location = new System.Drawing.Point(-1, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 73);
            this.panel3.TabIndex = 34;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(155)))), ((int)(((byte)(139)))));
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.Location = new System.Drawing.Point(32, 17);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(43, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 203);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxActiv
            // 
            this.comboBoxActiv.FormattingEnabled = true;
            this.comboBoxActiv.Location = new System.Drawing.Point(407, 285);
            this.comboBoxActiv.Name = "comboBoxActiv";
            this.comboBoxActiv.Size = new System.Drawing.Size(133, 21);
            this.comboBoxActiv.TabIndex = 58;
            // 
            // comboBoxStud
            // 
            this.comboBoxStud.FormattingEnabled = true;
            this.comboBoxStud.Location = new System.Drawing.Point(660, 285);
            this.comboBoxStud.Name = "comboBoxStud";
            this.comboBoxStud.Size = new System.Drawing.Size(128, 21);
            this.comboBoxStud.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID";
            // 
            // IDParticipare
            // 
            this.IDParticipare.AutoSize = true;
            this.IDParticipare.Location = new System.Drawing.Point(235, 285);
            this.IDParticipare.Name = "IDParticipare";
            this.IDParticipare.Size = new System.Drawing.Size(0, 13);
            this.IDParticipare.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Activitate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Student";
            // 
            // ParticipareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDParticipare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStud);
            this.Controls.Add(this.comboBoxActiv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParticipareForm";
            this.Text = "ParticipareForm";
            this.Load += new System.EventHandler(this.ParticipareForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ActualizeazaBtn;
        private System.Windows.Forms.Button Afiseaza;
        private System.Windows.Forms.Button StergeBtn;
        private System.Windows.Forms.Button AdaugaBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxActiv;
        private System.Windows.Forms.ComboBox comboBoxStud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDParticipare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}