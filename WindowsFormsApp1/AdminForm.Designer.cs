namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.btnIstrintiNaudotoja = new System.Windows.Forms.Button();
            this.btnRedaguotiNaudotoja = new System.Windows.Forms.Button();
            this.cmbRedaguotiRole = new System.Windows.Forms.ComboBox();
            this.txtRedaguotiPavarde = new System.Windows.Forms.TextBox();
            this.txtRedaguotiVardas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPridetiNaudotoja = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPavarde = new System.Windows.Forms.TextBox();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.dgvNaudotojai = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrupesPavadinimas = new System.Windows.Forms.TextBox();
            this.dgvGrupes = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Labell = new System.Windows.Forms.Label();
            this.btnPridetiGrupe = new System.Windows.Forms.Button();
            this.btnIstrintiGrupe = new System.Windows.Forms.Button();
            this.dvgStudentaiGrupeje = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dvgStudentaiNeGrupėje = new System.Windows.Forms.DataGridView();
            this.btnPridetiStudenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPasalintiStudenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dvgDalykai = new System.Windows.Forms.DataGridView();
            this.txtDalykasPavadinimas = new System.Windows.Forms.TextBox();
            this.cmbDestytojai = new System.Windows.Forms.ComboBox();
            this.btnPridetiDalyka = new System.Windows.Forms.Button();
            this.cmbStudentuGrupes = new System.Windows.Forms.ComboBox();
            this.btnPriskirtiDestytoja = new System.Windows.Forms.Button();
            this.btnPriskirtiGrupe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaudotojai)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupes)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentaiGrupeje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentaiNeGrupėje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDalykai)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UsersTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 751);
            this.tabControl1.TabIndex = 0;
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.btnIstrintiNaudotoja);
            this.UsersTab.Controls.Add(this.btnRedaguotiNaudotoja);
            this.UsersTab.Controls.Add(this.cmbRedaguotiRole);
            this.UsersTab.Controls.Add(this.txtRedaguotiPavarde);
            this.UsersTab.Controls.Add(this.txtRedaguotiVardas);
            this.UsersTab.Controls.Add(this.label3);
            this.UsersTab.Controls.Add(this.label2);
            this.UsersTab.Controls.Add(this.label1);
            this.UsersTab.Controls.Add(this.btnPridetiNaudotoja);
            this.UsersTab.Controls.Add(this.comboBox1);
            this.UsersTab.Controls.Add(this.txtPavarde);
            this.UsersTab.Controls.Add(this.txtVardas);
            this.UsersTab.Controls.Add(this.dgvNaudotojai);
            this.UsersTab.Location = new System.Drawing.Point(4, 25);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(959, 722);
            this.UsersTab.TabIndex = 0;
            this.UsersTab.Text = "Naudotojai";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // btnIstrintiNaudotoja
            // 
            this.btnIstrintiNaudotoja.Location = new System.Drawing.Point(402, 620);
            this.btnIstrintiNaudotoja.Name = "btnIstrintiNaudotoja";
            this.btnIstrintiNaudotoja.Size = new System.Drawing.Size(151, 23);
            this.btnIstrintiNaudotoja.TabIndex = 13;
            this.btnIstrintiNaudotoja.Text = "Ištrinti naudotoją";
            this.btnIstrintiNaudotoja.UseVisualStyleBackColor = true;
            this.btnIstrintiNaudotoja.Click += new System.EventHandler(this.btnIstrintiNaudotoja_Click_1);
            // 
            // btnRedaguotiNaudotoja
            // 
            this.btnRedaguotiNaudotoja.Location = new System.Drawing.Point(402, 529);
            this.btnRedaguotiNaudotoja.Name = "btnRedaguotiNaudotoja";
            this.btnRedaguotiNaudotoja.Size = new System.Drawing.Size(151, 23);
            this.btnRedaguotiNaudotoja.TabIndex = 12;
            this.btnRedaguotiNaudotoja.Text = "Redaguoti naudotoją";
            this.btnRedaguotiNaudotoja.UseVisualStyleBackColor = true;
            this.btnRedaguotiNaudotoja.Click += new System.EventHandler(this.btnRedaguotiNaudotoja_Click_1);
            // 
            // cmbRedaguotiRole
            // 
            this.cmbRedaguotiRole.FormattingEnabled = true;
            this.cmbRedaguotiRole.Items.AddRange(new object[] {
            "Administratorius",
            "Destytojas",
            "Studentas"});
            this.cmbRedaguotiRole.Location = new System.Drawing.Point(635, 489);
            this.cmbRedaguotiRole.Name = "cmbRedaguotiRole";
            this.cmbRedaguotiRole.Size = new System.Drawing.Size(151, 24);
            this.cmbRedaguotiRole.TabIndex = 11;
            // 
            // txtRedaguotiPavarde
            // 
            this.txtRedaguotiPavarde.Location = new System.Drawing.Point(399, 488);
            this.txtRedaguotiPavarde.Name = "txtRedaguotiPavarde";
            this.txtRedaguotiPavarde.Size = new System.Drawing.Size(154, 22);
            this.txtRedaguotiPavarde.TabIndex = 10;
            // 
            // txtRedaguotiVardas
            // 
            this.txtRedaguotiVardas.Location = new System.Drawing.Point(168, 489);
            this.txtRedaguotiVardas.Name = "txtRedaguotiVardas";
            this.txtRedaguotiVardas.Size = new System.Drawing.Size(154, 22);
            this.txtRedaguotiVardas.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rolė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pavardė";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vardas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPridetiNaudotoja
            // 
            this.btnPridetiNaudotoja.Location = new System.Drawing.Point(399, 436);
            this.btnPridetiNaudotoja.Name = "btnPridetiNaudotoja";
            this.btnPridetiNaudotoja.Size = new System.Drawing.Size(154, 23);
            this.btnPridetiNaudotoja.TabIndex = 5;
            this.btnPridetiNaudotoja.Text = "Pridėti naudotoją";
            this.btnPridetiNaudotoja.UseVisualStyleBackColor = true;
            this.btnPridetiNaudotoja.Click += new System.EventHandler(this.btnPridetiNaudotoja_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administratorius",
            "Destytojas",
            "Studentas"});
            this.comboBox1.Location = new System.Drawing.Point(632, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPavarde
            // 
            this.txtPavarde.Location = new System.Drawing.Point(399, 396);
            this.txtPavarde.Name = "txtPavarde";
            this.txtPavarde.Size = new System.Drawing.Size(154, 22);
            this.txtPavarde.TabIndex = 2;
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(168, 396);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(154, 22);
            this.txtVardas.TabIndex = 1;
            // 
            // dgvNaudotojai
            // 
            this.dgvNaudotojai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaudotojai.Location = new System.Drawing.Point(168, 50);
            this.dgvNaudotojai.Name = "dgvNaudotojai";
            this.dgvNaudotojai.RowHeadersWidth = 51;
            this.dgvNaudotojai.RowTemplate.Height = 24;
            this.dgvNaudotojai.Size = new System.Drawing.Size(618, 288);
            this.dgvNaudotojai.TabIndex = 0;
            this.dgvNaudotojai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNaudotojai_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnPasalintiStudenta);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnPridetiStudenta);
            this.tabPage2.Controls.Add(this.dvgStudentaiNeGrupėje);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dvgStudentaiGrupeje);
            this.tabPage2.Controls.Add(this.btnIstrintiGrupe);
            this.tabPage2.Controls.Add(this.btnPridetiGrupe);
            this.tabPage2.Controls.Add(this.Labell);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtGrupesPavadinimas);
            this.tabPage2.Controls.Add(this.dgvGrupes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grupės";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 2;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtGrupesPavadinimas
            // 
            this.txtGrupesPavadinimas.Location = new System.Drawing.Point(222, 221);
            this.txtGrupesPavadinimas.Name = "txtGrupesPavadinimas";
            this.txtGrupesPavadinimas.Size = new System.Drawing.Size(100, 22);
            this.txtGrupesPavadinimas.TabIndex = 1;
            // 
            // dgvGrupes
            // 
            this.dgvGrupes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupes.Location = new System.Drawing.Point(222, 32);
            this.dgvGrupes.Name = "dgvGrupes";
            this.dgvGrupes.RowHeadersWidth = 51;
            this.dgvGrupes.RowTemplate.Height = 24;
            this.dgvGrupes.Size = new System.Drawing.Size(496, 150);
            this.dgvGrupes.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPriskirtiGrupe);
            this.tabPage3.Controls.Add(this.btnPriskirtiDestytoja);
            this.tabPage3.Controls.Add(this.cmbStudentuGrupes);
            this.tabPage3.Controls.Add(this.btnPridetiDalyka);
            this.tabPage3.Controls.Add(this.cmbDestytojai);
            this.tabPage3.Controls.Add(this.txtDalykasPavadinimas);
            this.tabPage3.Controls.Add(this.dvgDalykai);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(959, 722);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dalykai";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Labell
            // 
            this.Labell.AutoSize = true;
            this.Labell.Location = new System.Drawing.Point(219, 205);
            this.Labell.Name = "Labell";
            this.Labell.Size = new System.Drawing.Size(132, 16);
            this.Labell.TabIndex = 3;
            this.Labell.Text = "Grupes pavadinimas";
            this.Labell.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnPridetiGrupe
            // 
            this.btnPridetiGrupe.Location = new System.Drawing.Point(338, 218);
            this.btnPridetiGrupe.Name = "btnPridetiGrupe";
            this.btnPridetiGrupe.Size = new System.Drawing.Size(156, 23);
            this.btnPridetiGrupe.TabIndex = 4;
            this.btnPridetiGrupe.Text = "Pridėti grupę";
            this.btnPridetiGrupe.UseVisualStyleBackColor = true;
            this.btnPridetiGrupe.Click += new System.EventHandler(this.btnPridetiGrupe_Click);
            // 
            // btnIstrintiGrupe
            // 
            this.btnIstrintiGrupe.Location = new System.Drawing.Point(593, 218);
            this.btnIstrintiGrupe.Name = "btnIstrintiGrupe";
            this.btnIstrintiGrupe.Size = new System.Drawing.Size(125, 23);
            this.btnIstrintiGrupe.TabIndex = 5;
            this.btnIstrintiGrupe.Text = "Ištrinti grupę";
            this.btnIstrintiGrupe.UseVisualStyleBackColor = true;
            this.btnIstrintiGrupe.Click += new System.EventHandler(this.btnIstrintiGrupe_Click);
            // 
            // dvgStudentaiGrupeje
            // 
            this.dvgStudentaiGrupeje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentaiGrupeje.Location = new System.Drawing.Point(222, 307);
            this.dvgStudentaiGrupeje.Name = "dvgStudentaiGrupeje";
            this.dvgStudentaiGrupeje.RowHeadersWidth = 51;
            this.dvgStudentaiGrupeje.RowTemplate.Height = 24;
            this.dvgStudentaiGrupeje.Size = new System.Drawing.Size(496, 150);
            this.dvgStudentaiGrupeje.TabIndex = 6;
            this.dvgStudentaiGrupeje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgStudentaiGrupeje_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Studentai grupėje";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // dvgStudentaiNeGrupėje
            // 
            this.dvgStudentaiNeGrupėje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentaiNeGrupėje.Location = new System.Drawing.Point(222, 523);
            this.dvgStudentaiNeGrupėje.Name = "dvgStudentaiNeGrupėje";
            this.dvgStudentaiNeGrupėje.RowHeadersWidth = 51;
            this.dvgStudentaiNeGrupėje.RowTemplate.Height = 24;
            this.dvgStudentaiNeGrupėje.Size = new System.Drawing.Size(496, 150);
            this.dvgStudentaiNeGrupėje.TabIndex = 8;
            this.dvgStudentaiNeGrupėje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgStudentaiNeGrupėje_CellContentClick);
            // 
            // btnPridetiStudenta
            // 
            this.btnPridetiStudenta.Location = new System.Drawing.Point(558, 680);
            this.btnPridetiStudenta.Name = "btnPridetiStudenta";
            this.btnPridetiStudenta.Size = new System.Drawing.Size(160, 23);
            this.btnPridetiStudenta.TabIndex = 9;
            this.btnPridetiStudenta.Text = "PridėtiStudenta";
            this.btnPridetiStudenta.UseVisualStyleBackColor = true;
            this.btnPridetiStudenta.Click += new System.EventHandler(this.btnPridetiStudenta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Studentai be grupės";
            // 
            // btnPasalintiStudenta
            // 
            this.btnPasalintiStudenta.Location = new System.Drawing.Point(558, 464);
            this.btnPasalintiStudenta.Name = "btnPasalintiStudenta";
            this.btnPasalintiStudenta.Size = new System.Drawing.Size(159, 23);
            this.btnPasalintiStudenta.TabIndex = 11;
            this.btnPasalintiStudenta.Text = "Pašalinti studentą";
            this.btnPasalintiStudenta.UseVisualStyleBackColor = true;
            this.btnPasalintiStudenta.Click += new System.EventHandler(this.btnPasalintiStudenta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Atnaujinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgDalykai
            // 
            this.dvgDalykai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDalykai.Location = new System.Drawing.Point(192, 20);
            this.dvgDalykai.Name = "dvgDalykai";
            this.dvgDalykai.RowHeadersWidth = 51;
            this.dvgDalykai.RowTemplate.Height = 24;
            this.dvgDalykai.Size = new System.Drawing.Size(575, 150);
            this.dvgDalykai.TabIndex = 0;
            this.dvgDalykai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDalykai_CellContentClick);
            // 
            // txtDalykasPavadinimas
            // 
            this.txtDalykasPavadinimas.Location = new System.Drawing.Point(192, 176);
            this.txtDalykasPavadinimas.Name = "txtDalykasPavadinimas";
            this.txtDalykasPavadinimas.Size = new System.Drawing.Size(425, 22);
            this.txtDalykasPavadinimas.TabIndex = 1;
            // 
            // cmbDestytojai
            // 
            this.cmbDestytojai.FormattingEnabled = true;
            this.cmbDestytojai.Location = new System.Drawing.Point(192, 235);
            this.cmbDestytojai.Name = "cmbDestytojai";
            this.cmbDestytojai.Size = new System.Drawing.Size(226, 24);
            this.cmbDestytojai.TabIndex = 2;
            // 
            // btnPridetiDalyka
            // 
            this.btnPridetiDalyka.Location = new System.Drawing.Point(644, 176);
            this.btnPridetiDalyka.Name = "btnPridetiDalyka";
            this.btnPridetiDalyka.Size = new System.Drawing.Size(123, 23);
            this.btnPridetiDalyka.TabIndex = 3;
            this.btnPridetiDalyka.Text = "Sukurti dalyką";
            this.btnPridetiDalyka.UseVisualStyleBackColor = true;
            this.btnPridetiDalyka.Click += new System.EventHandler(this.btnPridetiDalyka_Click);
            // 
            // cmbStudentuGrupes
            // 
            this.cmbStudentuGrupes.FormattingEnabled = true;
            this.cmbStudentuGrupes.Location = new System.Drawing.Point(192, 303);
            this.cmbStudentuGrupes.Name = "cmbStudentuGrupes";
            this.cmbStudentuGrupes.Size = new System.Drawing.Size(121, 24);
            this.cmbStudentuGrupes.TabIndex = 4;
            // 
            // btnPriskirtiDestytoja
            // 
            this.btnPriskirtiDestytoja.Location = new System.Drawing.Point(438, 235);
            this.btnPriskirtiDestytoja.Name = "btnPriskirtiDestytoja";
            this.btnPriskirtiDestytoja.Size = new System.Drawing.Size(179, 23);
            this.btnPriskirtiDestytoja.TabIndex = 5;
            this.btnPriskirtiDestytoja.Text = "Priskirti dėstytoją";
            this.btnPriskirtiDestytoja.UseVisualStyleBackColor = true;
            this.btnPriskirtiDestytoja.Click += new System.EventHandler(this.btnPriskirtiDestytoja_Click);
            // 
            // btnPriskirtiGrupe
            // 
            this.btnPriskirtiGrupe.Location = new System.Drawing.Point(339, 303);
            this.btnPriskirtiGrupe.Name = "btnPriskirtiGrupe";
            this.btnPriskirtiGrupe.Size = new System.Drawing.Size(170, 24);
            this.btnPriskirtiGrupe.TabIndex = 6;
            this.btnPriskirtiGrupe.Text = "Priskirti grupę";
            this.btnPriskirtiGrupe.UseVisualStyleBackColor = true;
            this.btnPriskirtiGrupe.Click += new System.EventHandler(this.btnPriskirtiGrupe_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 787);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaudotojai)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentaiGrupeje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentaiNeGrupėje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDalykai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvNaudotojai;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPavarde;
        private System.Windows.Forms.Button btnPridetiNaudotoja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRedaguotiPavarde;
        private System.Windows.Forms.TextBox txtRedaguotiVardas;
        private System.Windows.Forms.Button btnRedaguotiNaudotoja;
        private System.Windows.Forms.ComboBox cmbRedaguotiRole;
        private System.Windows.Forms.Button btnIstrintiNaudotoja;
        private System.Windows.Forms.DataGridView dgvGrupes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrupesPavadinimas;
        private System.Windows.Forms.Label Labell;
        private System.Windows.Forms.Button btnIstrintiGrupe;
        private System.Windows.Forms.Button btnPridetiGrupe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dvgStudentaiGrupeje;
        private System.Windows.Forms.DataGridView dvgStudentaiNeGrupėje;
        private System.Windows.Forms.Button btnPasalintiStudenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPridetiStudenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgDalykai;
        private System.Windows.Forms.ComboBox cmbDestytojai;
        private System.Windows.Forms.TextBox txtDalykasPavadinimas;
        private System.Windows.Forms.ComboBox cmbStudentuGrupes;
        private System.Windows.Forms.Button btnPridetiDalyka;
        private System.Windows.Forms.Button btnPriskirtiGrupe;
        private System.Windows.Forms.Button btnPriskirtiDestytoja;
    }
}