namespace Proiect_DataBase
{
    partial class StudentiForm
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
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.Afiseaza = new System.Windows.Forms.Button();
            this.NumeLbl = new System.Windows.Forms.Label();
            this.PrenumeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CNPLbl = new System.Windows.Forms.Label();
            this.TelefonLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.AdresaLbl = new System.Windows.Forms.Label();
            this.NumeTextBox = new System.Windows.Forms.TextBox();
            this.PrenumeTextBox = new System.Windows.Forms.TextBox();
            this.CNPTextBox = new System.Windows.Forms.TextBox();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AdresaTextBox = new System.Windows.Forms.TextBox();
            this.comboFacultate = new System.Windows.Forms.ComboBox();
            this.comboSpecializari = new System.Windows.Forms.ComboBox();
            this.AdaugaBtn = new System.Windows.Forms.Button();
            this.ActualizeazaBtn = new System.Windows.Forms.Button();
            this.StergeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            this.AnTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dataGridStudenti.GridColor = System.Drawing.Color.Crimson;
            this.dataGridStudenti.Location = new System.Drawing.Point(182, 65);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.Size = new System.Drawing.Size(606, 204);
            this.dataGridStudenti.TabIndex = 0;
            this.dataGridStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudenti_CellContentClick);
            // 
            // Afiseaza
            // 
            this.Afiseaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.Afiseaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Afiseaza.FlatAppearance.BorderSize = 0;
            this.Afiseaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afiseaza.ForeColor = System.Drawing.Color.Crimson;
            this.Afiseaza.Location = new System.Drawing.Point(11, 21);
            this.Afiseaza.Margin = new System.Windows.Forms.Padding(0);
            this.Afiseaza.Name = "Afiseaza";
            this.Afiseaza.Size = new System.Drawing.Size(150, 26);
            this.Afiseaza.TabIndex = 1;
            this.Afiseaza.Text = "AFISEAZA";
            this.Afiseaza.UseVisualStyleBackColor = false;
            this.Afiseaza.Click += new System.EventHandler(this.Afiseaza_Click);
            // 
            // NumeLbl
            // 
            this.NumeLbl.AutoSize = true;
            this.NumeLbl.Location = new System.Drawing.Point(194, 297);
            this.NumeLbl.Name = "NumeLbl";
            this.NumeLbl.Size = new System.Drawing.Size(35, 13);
            this.NumeLbl.TabIndex = 2;
            this.NumeLbl.Text = "Nume";
            // 
            // PrenumeLbl
            // 
            this.PrenumeLbl.AutoSize = true;
            this.PrenumeLbl.Location = new System.Drawing.Point(194, 322);
            this.PrenumeLbl.Name = "PrenumeLbl";
            this.PrenumeLbl.Size = new System.Drawing.Size(49, 13);
            this.PrenumeLbl.TabIndex = 3;
            this.PrenumeLbl.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Facultate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Specializare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "AnStudiu";
            // 
            // CNPLbl
            // 
            this.CNPLbl.AutoSize = true;
            this.CNPLbl.Location = new System.Drawing.Point(364, 346);
            this.CNPLbl.Name = "CNPLbl";
            this.CNPLbl.Size = new System.Drawing.Size(29, 13);
            this.CNPLbl.TabIndex = 7;
            this.CNPLbl.Text = "CNP";
            // 
            // TelefonLbl
            // 
            this.TelefonLbl.AutoSize = true;
            this.TelefonLbl.Location = new System.Drawing.Point(611, 290);
            this.TelefonLbl.Name = "TelefonLbl";
            this.TelefonLbl.Size = new System.Drawing.Size(43, 13);
            this.TelefonLbl.TabIndex = 8;
            this.TelefonLbl.Text = "Telefon";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(611, 315);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 9;
            this.EmailLbl.Text = "Email";
            // 
            // AdresaLbl
            // 
            this.AdresaLbl.AutoSize = true;
            this.AdresaLbl.Location = new System.Drawing.Point(611, 343);
            this.AdresaLbl.Name = "AdresaLbl";
            this.AdresaLbl.Size = new System.Drawing.Size(40, 13);
            this.AdresaLbl.TabIndex = 10;
            this.AdresaLbl.Text = "Adresa";
            // 
            // NumeTextBox
            // 
            this.NumeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.NumeTextBox.Location = new System.Drawing.Point(250, 294);
            this.NumeTextBox.Name = "NumeTextBox";
            this.NumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeTextBox.TabIndex = 11;
            // 
            // PrenumeTextBox
            // 
            this.PrenumeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.PrenumeTextBox.Location = new System.Drawing.Point(250, 319);
            this.PrenumeTextBox.Name = "PrenumeTextBox";
            this.PrenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrenumeTextBox.TabIndex = 12;
            // 
            // CNPTextBox
            // 
            this.CNPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.CNPTextBox.Location = new System.Drawing.Point(434, 344);
            this.CNPTextBox.Name = "CNPTextBox";
            this.CNPTextBox.Size = new System.Drawing.Size(171, 20);
            this.CNPTextBox.TabIndex = 16;
            // 
            // TelefonTextBox
            // 
            this.TelefonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.TelefonTextBox.Location = new System.Drawing.Point(652, 290);
            this.TelefonTextBox.Name = "TelefonTextBox";
            this.TelefonTextBox.Size = new System.Drawing.Size(136, 20);
            this.TelefonTextBox.TabIndex = 17;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.EmailTextBox.Location = new System.Drawing.Point(652, 315);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(136, 20);
            this.EmailTextBox.TabIndex = 18;
            // 
            // AdresaTextBox
            // 
            this.AdresaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.AdresaTextBox.Location = new System.Drawing.Point(652, 341);
            this.AdresaTextBox.Name = "AdresaTextBox";
            this.AdresaTextBox.Size = new System.Drawing.Size(136, 20);
            this.AdresaTextBox.TabIndex = 19;
            // 
            // comboFacultate
            // 
            this.comboFacultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.comboFacultate.FormattingEnabled = true;
            this.comboFacultate.Items.AddRange(new object[] {
            "FIESC",
            "FEAA",
            "FIG",
            "FSE"});
            this.comboFacultate.Location = new System.Drawing.Point(250, 344);
            this.comboFacultate.Name = "comboFacultate";
            this.comboFacultate.Size = new System.Drawing.Size(100, 21);
            this.comboFacultate.TabIndex = 20;
            this.comboFacultate.SelectedIndexChanged += new System.EventHandler(this.comboFacultate_SelectedIndexChanged);
            // 
            // comboSpecializari
            // 
            this.comboSpecializari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.comboSpecializari.FormattingEnabled = true;
            this.comboSpecializari.Location = new System.Drawing.Point(434, 290);
            this.comboSpecializari.Name = "comboSpecializari";
            this.comboSpecializari.Size = new System.Drawing.Size(171, 21);
            this.comboSpecializari.TabIndex = 21;
            this.comboSpecializari.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AdaugaBtn
            // 
            this.AdaugaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.AdaugaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdaugaBtn.FlatAppearance.BorderSize = 0;
            this.AdaugaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdaugaBtn.ForeColor = System.Drawing.Color.Crimson;
            this.AdaugaBtn.Location = new System.Drawing.Point(11, 60);
            this.AdaugaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AdaugaBtn.Name = "AdaugaBtn";
            this.AdaugaBtn.Size = new System.Drawing.Size(150, 23);
            this.AdaugaBtn.TabIndex = 22;
            this.AdaugaBtn.Text = "ADAUGA";
            this.AdaugaBtn.UseVisualStyleBackColor = false;
            this.AdaugaBtn.Click += new System.EventHandler(this.AdaugaBtn_Click);
            // 
            // ActualizeazaBtn
            // 
            this.ActualizeazaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ActualizeazaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizeazaBtn.FlatAppearance.BorderSize = 0;
            this.ActualizeazaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizeazaBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ActualizeazaBtn.Location = new System.Drawing.Point(11, 99);
            this.ActualizeazaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ActualizeazaBtn.Name = "ActualizeazaBtn";
            this.ActualizeazaBtn.Size = new System.Drawing.Size(150, 23);
            this.ActualizeazaBtn.TabIndex = 23;
            this.ActualizeazaBtn.Text = "ACTUALIZEAZA";
            this.ActualizeazaBtn.UseVisualStyleBackColor = false;
            this.ActualizeazaBtn.Click += new System.EventHandler(this.ActualizeazaBtn_Click);
            // 
            // StergeBtn
            // 
            this.StergeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.StergeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StergeBtn.FlatAppearance.BorderSize = 0;
            this.StergeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StergeBtn.ForeColor = System.Drawing.Color.Crimson;
            this.StergeBtn.Location = new System.Drawing.Point(11, 137);
            this.StergeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StergeBtn.Name = "StergeBtn";
            this.StergeBtn.Size = new System.Drawing.Size(150, 23);
            this.StergeBtn.TabIndex = 25;
            this.StergeBtn.Text = "STERGE";
            this.StergeBtn.UseVisualStyleBackColor = false;
            this.StergeBtn.Click += new System.EventHandler(this.StergeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MinusBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 53);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "STUDENTI";
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
            this.panel2.Controls.Add(this.ActualizeazaBtn);
            this.panel2.Controls.Add(this.Afiseaza);
            this.panel2.Controls.Add(this.StergeBtn);
            this.panel2.Controls.Add(this.AdaugaBtn);
            this.panel2.Location = new System.Drawing.Point(-2, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 407);
            this.panel2.TabIndex = 27;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.Crimson;
            this.BackBtn.Location = new System.Drawing.Point(32, 17);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(43, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Location = new System.Drawing.Point(-1, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 73);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID ";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(247, 272);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(0, 13);
            this.IDLbl.TabIndex = 30;
            // 
            // AnTextBox
            // 
            this.AnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.AnTextBox.Location = new System.Drawing.Point(434, 317);
            this.AnTextBox.Name = "AnTextBox";
            this.AnTextBox.Size = new System.Drawing.Size(171, 20);
            this.AnTextBox.TabIndex = 31;
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnTextBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboSpecializari);
            this.Controls.Add(this.comboFacultate);
            this.Controls.Add(this.AdresaTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.TelefonTextBox);
            this.Controls.Add(this.CNPTextBox);
            this.Controls.Add(this.PrenumeTextBox);
            this.Controls.Add(this.NumeTextBox);
            this.Controls.Add(this.AdresaLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.TelefonLbl);
            this.Controls.Add(this.CNPLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrenumeLbl);
            this.Controls.Add(this.NumeLbl);
            this.Controls.Add(this.dataGridStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentiForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStudenti;
        private System.Windows.Forms.Button Afiseaza;
        private System.Windows.Forms.Label NumeLbl;
        private System.Windows.Forms.Label PrenumeLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CNPLbl;
        private System.Windows.Forms.Label TelefonLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label AdresaLbl;
        private System.Windows.Forms.TextBox NumeTextBox;
        private System.Windows.Forms.TextBox PrenumeTextBox;
        private System.Windows.Forms.TextBox CNPTextBox;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AdresaTextBox;
        private System.Windows.Forms.ComboBox comboFacultate;
        private System.Windows.Forms.ComboBox comboSpecializari;
        private System.Windows.Forms.Button AdaugaBtn;
        private System.Windows.Forms.Button ActualizeazaBtn;
        private System.Windows.Forms.Button StergeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.TextBox AnTextBox;
        private System.Windows.Forms.Label label2;
    }
}

