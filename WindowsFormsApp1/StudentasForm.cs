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
    public partial class StudentasForm : Form
    {
        public StudentasForm(int studentasId)
        {
            InitializeComponent();
            this.studentasId = studentasId;
        }

        private void StudentasForm_Load(object sender, EventArgs e)
        {
            RodytiPazymius();
        }

        private Studentas studentas;

        public StudentasForm(Studentas studentas)
        {
            InitializeComponent();
            this.studentas = studentas;
        }

        private void dvgPazymiai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int studentasId;



        private void RodytiPazymius()
        {
            DatabaseService db = new DatabaseService();
            DataTable pazymiai = db.GautiStudentoPazymius(studentasId);
            dvgPazymiai.DataSource = pazymiai;
            dvgPazymiai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }

}
