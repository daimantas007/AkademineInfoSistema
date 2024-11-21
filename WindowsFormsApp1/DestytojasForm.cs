using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DestytojasForm : Form
    {
        public DestytojasForm()
        {
            InitializeComponent();



        }

        private void DestytojasForm_Load(object sender, EventArgs e)
        {
            RodytiDalykus();

        }

        private Destytojas destytojas;

        public DestytojasForm(Destytojas destytojas)
        {
            InitializeComponent();
            this.destytojas = destytojas;
        }

        private void dvgDalykai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RodytiDalykus()
        {
            DatabaseService db = new DatabaseService();
            DataTable dalykai = db.GautiDalykusDestytojui(destytojas.Id);
            dvgDalykai.DataSource = dalykai;
            dvgDalykai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RodytiGrupes(int dalykoId)
        {
            DatabaseService db = new DatabaseService();
            DataTable grupes = db.GautiGrupesDalykui(dalykoId);
            dvgGrupes.DataSource = grupes;
            dvgGrupes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dvgGrupes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RodytiStudentus(int grupesId)
        {
            DatabaseService db = new DatabaseService();
            DataTable studentaidalyke = db.GautiStudentusGrupėje(grupesId);
            dvgStudentai.DataSource = studentaidalyke;
            dvgStudentai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void btnIssaugotiPazymius_Click_1(object sender, EventArgs e)
        {

            if (dvgDalykai.SelectedRows.Count == 0 || dvgStudentai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pasirinkite dalyką ir studentą.");
                return;
            }

            if (!int.TryParse(txtIvertinimas.Text, out int pazymys))
            {
                MessageBox.Show("Prašome įvesti teisingą pažymį.");
                return;
            }

            int dalykoId = Convert.ToInt32(dvgDalykai.SelectedRows[0].Cells["ID"].Value);
            int studentasId = Convert.ToInt32(dvgStudentai.SelectedRows[0].Cells["StudentasID"].Value);

            DatabaseService db = new DatabaseService();
            db.PridetiArPakeistiPazymi(studentasId, dalykoId, pazymys);

            MessageBox.Show("Pažymys sėkmingai pridėtas arba pakeistas!");
            txtIvertinimas.Clear();

            // Atnaujinti studentų sąrašą
            int grupesId = Convert.ToInt32(dvgGrupes.SelectedRows[0].Cells["ID"].Value);
            RodytiStudentusSuPazymiais(grupesId, dalykoId);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseService db = new DatabaseService();

            if (dvgDalykai.Rows.Count > 0)
            {
                int dalykoId = Convert.ToInt32(dvgDalykai.SelectedRows[0].Cells["ID"].Value);

                // 2. Rodyti grupes
                RodytiGrupes(dalykoId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseService db = new DatabaseService();
            int dalykoId = Convert.ToInt32(dvgDalykai.SelectedRows[0].Cells["ID"].Value);;
            int grupesId = Convert.ToInt32(dvgGrupes.SelectedRows[0].Cells["ID"].Value);
            RodytiStudentusSuPazymiais(grupesId, dalykoId);
        }

        private void dvgStudentai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void RodytiStudentusSuPazymiais(int grupesId, int dalykoId)
        {
            DatabaseService db = new DatabaseService();
            DataTable studentai = db.GautiStudentusGrupėjeSuPazymiais(grupesId, dalykoId);
            dvgStudentai.DataSource = studentai;
            dvgStudentai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}