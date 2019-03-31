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

namespace CollegeRegistration
{
    public partial class StudentForm : Form
    {
        
        public StudentForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Students.Load();
            RegistrationClass.RegistrationEntities.Majors.Load();
            dataGridView1.DataSource = RegistrationClass.RegistrationEntities.Students.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
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
            string findMajor = textBox1.Text;
            var MajorFilter = RegistrationClass.RegistrationEntities.Students.Where(f => f.Major.Name == (findMajor)).ToList();
            //MajorFilter = MajorFilter.Where(f => f.Major.Name ==
            
            

            foreach (var Filter in MajorFilter)
            {
                Filte+= Filter.Name;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
