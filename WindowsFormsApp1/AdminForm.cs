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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RodytiNaudotojus();
            RodytiGrupes();
            RodytiDalykus();
            UzpildytiDestytojuSarasa();
            UzpildytiStudentuGrupiuSarasa();

            if (dgvGrupes.Rows.Count > 0)
            {
                dgvGrupes.Rows[0].Selected = true; // Pažymi pirmą grupę
                int grupesId = Convert.ToInt32(dgvGrupes.Rows[0].Cells["ID"].Value);

                RodytiStudentusGrupėje(grupesId);
                RodytiStudentusNeGrupėje();
            }

        }

        private Administratorius admin;


        public AdminForm(Administratorius administratorius)
        {
            InitializeComponent();
            this.admin = administratorius;
        }

        private void dgvNaudotojai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNaudotojai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNaudotojai.SelectedRows.Count > 0)
            {
                txtRedaguotiVardas.Text = dgvNaudotojai.SelectedRows[0].Cells["Vardas"].Value.ToString();
                txtRedaguotiPavarde.Text = dgvNaudotojai.SelectedRows[0].Cells["Pavarde"].Value.ToString();
                cmbRedaguotiRole.SelectedItem = dgvNaudotojai.SelectedRows[0].Cells["Role"].Value.ToString();
            }
        }

        private void RodytiNaudotojus()
        {
            DatabaseService db = new DatabaseService(); // Inicijuojame duomenų bazės klasę
            DataTable naudotojai = db.GautiVisusNaudotojus(); // Gauname naudotojų sąrašą
            dgvNaudotojai.DataSource = naudotojai; // Priskiriame lentelę DataGridView
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPridetiNaudotoja_Click(object sender, EventArgs e)
        {
            string vardas = txtVardas.Text;
            string pavarde = txtPavarde.Text;
            string role = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(vardas) || string.IsNullOrWhiteSpace(pavarde) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Prašome užpildyti visus laukus.");
                return;
            }

            DatabaseService db = new DatabaseService();
            db.PridetiNaudotoja(vardas, pavarde, role);
            MessageBox.Show($"Naudotojas {vardas} {pavarde} sukurtas!");

            RodytiNaudotojus(); // Atnaujinti naudotojų sąrašą


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRedaguotiNaudotoja_Click_1(object sender, EventArgs e)
        {
            if (dgvNaudotojai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prašome pasirinkti naudotoją redagavimui.");
                return;
            }

            int id = Convert.ToInt32(dgvNaudotojai.SelectedRows[0].Cells["ID"].Value);
            string vardas = txtRedaguotiVardas.Text;
            string pavarde = txtRedaguotiPavarde.Text;
            string role = cmbRedaguotiRole.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(vardas) || string.IsNullOrWhiteSpace(pavarde) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Prašome užpildyti visus laukus.");
                return;
            }

            DatabaseService db = new DatabaseService();
            db.RedaguotiNaudotoja(id, vardas, pavarde, role);
            MessageBox.Show($"Naudotojas {vardas} {pavarde} atnaujintas!");

            RodytiNaudotojus(); // Atnaujinti naudotojų sąrašą
        }

        private void btnIstrintiNaudotoja_Click_1(object sender, EventArgs e)
        {
            if (dgvNaudotojai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prašome pasirinkti naudotoją ištrynimui.");
                return;
            }

            int id = Convert.ToInt32(dgvNaudotojai.SelectedRows[0].Cells["ID"].Value);

            if (MessageBox.Show("Ar tikrai norite ištrinti šį naudotoją?", "Patvirtinimas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseService db = new DatabaseService();
                db.IstrintiNaudotoja(id);
                MessageBox.Show("Naudotojas ištrintas!");

                RodytiNaudotojus(); // Atnaujinti naudotojų sąrašą
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void RodytiGrupes()
        {
            DatabaseService db = new DatabaseService();
            dgvGrupes.DataSource = db.GautiVisasGrupe();
        }

        private void btnPridetiGrupe_Click(object sender, EventArgs e)
        {
            string pavadinimas = txtGrupesPavadinimas.Text;

            if (string.IsNullOrWhiteSpace(pavadinimas))
            {
                MessageBox.Show("Įveskite grupės pavadinimą.");
                return;
            }

            DatabaseService db = new DatabaseService();
            db.KurtiGrupe(pavadinimas);
            MessageBox.Show($"Grupė '{pavadinimas}' sukurta!");

            RodytiGrupes();
        }

        private void btnIstrintiGrupe_Click(object sender, EventArgs e)
        {
            if (dgvGrupes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pasirinkite grupę.");
                return;
            }

            int grupesId = Convert.ToInt32(dgvGrupes.SelectedRows[0].Cells["ID"].Value);

            DatabaseService db = new DatabaseService();
            db.SalintiGrupe(grupesId);
            MessageBox.Show("Grupė ištrinta!");

            RodytiGrupes();
        }


        private void RodytiStudentusGrupėje(int grupesId)
        {
            DatabaseService db = new DatabaseService();
            DataTable studentaiGrupėje = db.GautiStudentusGrupėje(grupesId);
            dvgStudentaiGrupeje.DataSource = studentaiGrupėje;

            // Gražesnis DataGridView vaizdas
            dvgStudentaiGrupeje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RodytiStudentusNeGrupėje()
        {
            DatabaseService db = new DatabaseService();
            DataTable studentaiNeGrupėje = db.GautiStudentusNeGrupėje();
            dvgStudentaiNeGrupėje.DataSource = studentaiNeGrupėje;

            // Gražesnis DataGridView vaizdas
            dvgStudentaiNeGrupėje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dvgStudentaiGrupeje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgStudentaiNeGrupėje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPridetiStudenta_Click(object sender, EventArgs e)
        {
            if (dgvGrupes.SelectedRows.Count == 0 || dvgStudentaiNeGrupėje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pasirinkite grupę ir studentą.");
                return;
            }

            int grupesId = Convert.ToInt32(dgvGrupes.SelectedRows[0].Cells["ID"].Value);
            int studentasId = Convert.ToInt32(dvgStudentaiNeGrupėje.SelectedRows[0].Cells["ID"].Value);

            DatabaseService db = new DatabaseService();
            db.PridetiStudentaGrupei(studentasId, grupesId);

            MessageBox.Show("Studentas pridėtas į grupę!");

            // Atnaujina studentų sąrašus
            RodytiStudentusGrupėje(grupesId);
            RodytiStudentusNeGrupėje();
        }

        private void btnPasalintiStudenta_Click(object sender, EventArgs e)
        {
            if (dgvGrupes.SelectedRows.Count == 0 || dvgStudentaiGrupeje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pasirinkite grupę ir studentą.");
                return;
            }

            int grupesId = Convert.ToInt32(dgvGrupes.SelectedRows[0].Cells["ID"].Value);
            int studentasId = Convert.ToInt32(dvgStudentaiGrupeje.SelectedRows[0].Cells["ID"].Value);

            DatabaseService db = new DatabaseService();
            db.PasalintiStudentaIsGrupes(studentasId, grupesId);

            MessageBox.Show("Studentas pašalintas iš grupės!");

            // Atnaujina studentų sąrašus
            RodytiStudentusGrupėje(grupesId);
            RodytiStudentusNeGrupėje();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseService db = new DatabaseService();
            int grupesId = Convert.ToInt32(dgvGrupes.SelectedRows[0].Cells["ID"].Value);


            RodytiStudentusGrupėje(grupesId);
            RodytiStudentusNeGrupėje();
        }
    


        private void RodytiDalykus()
        {
            DatabaseService db = new DatabaseService();
            dvgDalykai.DataSource = db.GautiVisusDalykus();

            // Gražesnis DataGridView vaizdas
            dvgDalykai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dvgDalykai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UzpildytiDestytojuSarasa()
        {
            DatabaseService db = new DatabaseService();
            DataTable destytojai = db.GautiDestytojus(); // Sukurkite metodą, kuris grąžina tik dėstytojus

            cmbDestytojai.DataSource = destytojai;
            cmbDestytojai.DisplayMember = "Vardas";
            cmbDestytojai.ValueMember = "ID";
        }


        private void UzpildytiStudentuGrupiuSarasa()
        {
            DatabaseService db = new DatabaseService();
            DataTable grupes = db.GautiVisasGrupe();

            cmbStudentuGrupes.DataSource = grupes;
            cmbStudentuGrupes.DisplayMember = "GrupesPavadinimas";
            cmbStudentuGrupes.ValueMember = "ID";
        }

        private void btnPridetiDalyka_Click(object sender, EventArgs e)
        {
            string pavadinimas = txtDalykasPavadinimas.Text;

            if (string.IsNullOrWhiteSpace(pavadinimas))
            {
                MessageBox.Show("Įveskite dalyko pavadinimą.");
                return;
            }

            DatabaseService db = new DatabaseService();
            db.KurtiDalyka(pavadinimas);

            MessageBox.Show($"Dalykas '{pavadinimas}' sukurtas!");
            RodytiDalykus();
        }

        private void btnPriskirtiDestytoja_Click(object sender, EventArgs e)
        {
            if (dvgDalykai.SelectedRows.Count == 0 || cmbDestytojai.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite dalyką ir dėstytoją.");
                return;
            }

            int dalykoId = Convert.ToInt32(dvgDalykai.SelectedRows[0].Cells["ID"].Value);
            int destytojasId = Convert.ToInt32(cmbDestytojai.SelectedValue);

            DatabaseService db = new DatabaseService();
            db.PriskirtiDestytojaDalykui(dalykoId, destytojasId);

            MessageBox.Show("Dėstytojas priskirtas dalykui!");
            RodytiDalykus();
        }

        private void btnPriskirtiGrupe_Click(object sender, EventArgs e)
        {
            if (dvgDalykai.SelectedRows.Count == 0 || cmbStudentuGrupes.SelectedItem == null)
            {
                MessageBox.Show("Pasirinkite dalyką ir grupę.");
                return;
            }

            int dalykoId = Convert.ToInt32(dvgDalykai.SelectedRows[0].Cells["ID"].Value);
            int grupesId = Convert.ToInt32(cmbStudentuGrupes.SelectedValue);

            DatabaseService db = new DatabaseService();
            db.PriskirtiGrupeDalykui(dalykoId, grupesId);

            MessageBox.Show("Grupė priskirta dalykui!");
        }
    }
}