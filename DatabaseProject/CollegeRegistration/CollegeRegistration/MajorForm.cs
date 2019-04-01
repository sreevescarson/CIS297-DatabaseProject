using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.OleDb;

namespace CollegeRegistration
{
    public partial class MajorForm : Form
    {
        public MajorForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Students.Load();
            RegistrationClass.RegistrationEntities.Majors.Load();

            dataGridView1.DataSource = RegistrationClass.RegistrationEntities.Majors.Local.ToBindingList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MajorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.Major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.registrationDataSet.Major);

        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
