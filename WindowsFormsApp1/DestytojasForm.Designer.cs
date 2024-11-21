namespace WindowsFormsApp1
{
    partial class DestytojasForm
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
            this.dvgDalykai = new System.Windows.Forms.DataGridView();
            this.dvgGrupes = new System.Windows.Forms.DataGridView();
            this.dvgStudentai = new System.Windows.Forms.DataGridView();
            this.btnIssaugotiPazymius = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIvertinimas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDalykai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrupes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentai)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDalykai
            // 
            this.dvgDalykai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDalykai.Location = new System.Drawing.Point(230, 63);
            this.dvgDalykai.Name = "dvgDalykai";
            this.dvgDalykai.RowHeadersWidth = 51;
            this.dvgDalykai.RowTemplate.Height = 24;
            this.dvgDalykai.Size = new System.Drawing.Size(514, 150);
            this.dvgDalykai.TabIndex = 0;
            this.dvgDalykai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDalykai_CellContentClick);
            // 
            // dvgGrupes
            // 
            this.dvgGrupes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGrupes.Location = new System.Drawing.Point(230, 267);
            this.dvgGrupes.Name = "dvgGrupes";
            this.dvgGrupes.RowHeadersWidth = 51;
            this.dvgGrupes.RowTemplate.Height = 24;
            this.dvgGrupes.Size = new System.Drawing.Size(514, 150);
            this.dvgGrupes.TabIndex = 1;
            this.dvgGrupes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgGrupes_CellContentClick);
            // 
            // dvgStudentai
            // 
            this.dvgStudentai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudentai.Location = new System.Drawing.Point(230, 487);
            this.dvgStudentai.Name = "dvgStudentai";
            this.dvgStudentai.RowHeadersWidth = 51;
            this.dvgStudentai.RowTemplate.Height = 24;
            this.dvgStudentai.Size = new System.Drawing.Size(514, 150);
            this.dvgStudentai.TabIndex = 2;
            this.dvgStudentai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgStudentai_CellContentClick);
            // 
            // btnIssaugotiPazymius
            // 
            this.btnIssaugotiPazymius.Location = new System.Drawing.Point(554, 643);
            this.btnIssaugotiPazymius.Name = "btnIssaugotiPazymius";
            this.btnIssaugotiPazymius.Size = new System.Drawing.Size(190, 50);
            this.btnIssaugotiPazymius.TabIndex = 3;
            this.btnIssaugotiPazymius.Text = "Išsaugoti pažymius";
            this.btnIssaugotiPazymius.UseVisualStyleBackColor = true;
            this.btnIssaugotiPazymius.Click += new System.EventHandler(this.btnIssaugotiPazymius_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Grupės";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Studentai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIvertinimas
            // 
            this.txtIvertinimas.Location = new System.Drawing.Point(448, 657);
            this.txtIvertinimas.Name = "txtIvertinimas";
            this.txtIvertinimas.Size = new System.Drawing.Size(100, 22);
            this.txtIvertinimas.TabIndex = 6;
            // 
            // DestytojasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 826);
            this.Controls.Add(this.txtIvertinimas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIssaugotiPazymius);
            this.Controls.Add(this.dvgStudentai);
            this.Controls.Add(this.dvgGrupes);
            this.Controls.Add(this.dvgDalykai);
            this.Name = "DestytojasForm";
            this.Text = "DestytojasForm";
            this.Load += new System.EventHandler(this.DestytojasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDalykai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGrupes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudentai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDalykai;
        private System.Windows.Forms.DataGridView dvgGrupes;
        private System.Windows.Forms.DataGridView dvgStudentai;
        private System.Windows.Forms.Button btnIssaugotiPazymius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIvertinimas;
    }
}