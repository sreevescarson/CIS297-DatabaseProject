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
    public partial class StudentForm : Form
    {
        DataTable dataTable = new DataTable();

        public StudentForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Students.Load();
            RegistrationClass.RegistrationEntities.Majors.Load();

            dataGridView1.DataSource = RegistrationClass.RegistrationEntities.Students.Local.ToBindingList();

            /*
            dataGridView1.Columns.Add("Major Name", "Major Name");

            int count = RegistrationClass.RegistrationEntities.Students.Count();
            int checkCount = 0;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string value;
                
                value = row.Cells[1].Value.ToString();
                
                int NewValue = int.Parse(value);
                
                DataGridViewColumn column = dataGridView1.Columns[2];
                DataGridViewCell cell = new DataGridViewTextBoxCell();

                var GetMajorName = RegistrationClass.RegistrationEntities.Majors.Where(m => m.Id == NewValue).ToList();
                string stuff = GetMajorName[0].Name;
                
                stuff.Substring(0, 4);
                dataGridView1[2, checkCount].Value = stuff;

                checkCount++;
                if (checkCount >= count)
                    break;
            }
            */
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

            var list = new BindingList<Student>(MajorFilter);
            FilteredDataGrid.DataSource = list;
            FilteredDataGrid.Columns["Major"].Visible = false;
            FilteredDataGrid.Columns["Enrollments"].Visible = false;
            ClearTextBoxes();
            /*
            foreach (var Filter in MajorFilter)
            {
                var list = new BindingList<Student>(MajorFilter);
                FilteredDataGrid.DataSource = list;
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Student NewStudent = new Student
            {
                Name = NameInput.Text,
                MajorID = int.Parse(MajorIDInput.Text)
            };
            var MajorFilter = RegistrationClass.RegistrationEntities.Students.Where(f => f.Major.Id == (NewStudent.MajorID)).ToList();

            if (MajorFilter.Count > 0)
            {
                RegistrationClass.RegistrationEntities.Students.Add(NewStudent);
                RegistrationClass.RegistrationEntities.SaveChanges();
            }

            else
            {
                MessageBox.Show("Major ID does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearTextBoxes();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                DataTable dataTable = new DataTable();
                dataGridView1.Update();
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Major ID does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("Name cannot be Null or over 50 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Student DeleteRecord = new Student();
            try
            {
                string DeleteName = NameInput.Text;

                DeleteRecord = (from stud in RegistrationClass.RegistrationEntities.Students
                                    where stud.Name == DeleteName
                                    select stud).FirstOrDefault();

                RegistrationClass.RegistrationEntities.Students.Remove(DeleteRecord);
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Cannot delete record due to current and/or prior enrollments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrationClass.RegistrationEntities.Students.Load();
            }

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            NameInput.Text = "";
            MajorIDInput.Text = "";
        }

        private void FilteredDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
