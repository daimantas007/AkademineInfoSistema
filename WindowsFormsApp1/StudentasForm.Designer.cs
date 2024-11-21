namespace WindowsFormsApp1
{
    partial class StudentasForm
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
            this.dvgPazymiai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPazymiai)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPazymiai
            // 
            this.dvgPazymiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPazymiai.Location = new System.Drawing.Point(12, 22);
            this.dvgPazymiai.Name = "dvgPazymiai";
            this.dvgPazymiai.RowHeadersWidth = 51;
            this.dvgPazymiai.RowTemplate.Height = 24;
            this.dvgPazymiai.Size = new System.Drawing.Size(776, 416);
            this.dvgPazymiai.TabIndex = 0;
            this.dvgPazymiai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPazymiai_CellContentClick);
            // 
            // StudentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgPazymiai);
            this.Name = "StudentasForm";
            this.Text = "StudentasForm";
            this.Load += new System.EventHandler(this.StudentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPazymiai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPazymiai;
    }
}