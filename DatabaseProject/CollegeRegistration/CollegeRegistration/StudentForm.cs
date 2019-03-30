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

namespace CollegeRegistration
{
    public partial class StudentForm : Form
    {
        
        public StudentForm(RegistrationEntities RegistrationEntities)
        {
            InitializeComponent();
            RegistrationEntities.Students.Load();
            dataGridView1.DataSource = RegistrationEntities.Students.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentDataSet.Students);
            // TODO: This line of code loads data into the 'registrationDataSet.Major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.registrationDataSet.Major);
            // TODO: This line of code loads data into the 'registrationDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.registrationDataSet.Student);

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FindStudentButton_Click(object sender, EventArgs e)
        {
            string FindPerson = textBox1.Text;
        }
    }
}
