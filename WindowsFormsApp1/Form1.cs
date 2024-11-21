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
    public partial class Form1 : Form
    {
        private DatabaseService db = new DatabaseService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vardas = textBox1.Text;
            string slaptazodis = textBox2.Text;

            // Bando prisijungti naudotojas
            Naudotojas naudotojas = db.Prisijungti(vardas, slaptazodis);

            if (naudotojas != null)
            {
                MessageBox.Show($"Sveiki, {naudotojas.Vardas}!");
                this.Hide();

                // Atidaro atitinkamą formą pagal rolę
                if (naudotojas is Administratorius)
                {
                    var adminForm = new AdminForm((Administratorius)naudotojas);
                    adminForm.ShowDialog();
                }
                else if ( naudotojas is Destytojas)
                {
                    var destytojasForm = new DestytojasForm((Destytojas)naudotojas);
                        destytojasForm.ShowDialog();
                }
                if (naudotojas is Studentas studentas)
                {
                    var studentasForm = new StudentasForm(studentas.Id);
                    studentasForm.ShowDialog();
                }



                this.Show();
            }
            else
            {
                MessageBox.Show("Neteisingas prisijungimo vardas arba slaptažodis.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
