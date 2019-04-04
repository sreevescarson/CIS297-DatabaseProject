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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Courses.Load();
            CourseGrid.DataSource = RegistrationClass.RegistrationEntities.Courses.Local.ToBindingList();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.courseDataSet.Course);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindDeptButton_Click(object sender, EventArgs e)
        {
            string findDepartment = DepartmentSearch.Text;
            var DepartmentFilter = RegistrationClass.RegistrationEntities.Courses.Where(f => f.Department == (findDepartment)).ToList();

            var list = new BindingList<Course>(DepartmentFilter);
            dataGridView1.DataSource = list;
            ClearTextBoxes();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            string Name = CourseNameInput.Text;
            int Number = int.Parse(CourseNumberInput.Text);
            int Credits = int.Parse(CreditsInput.Text);
            string Department = DepartmentInput.Text;

            Course NewCourse = new Course
            {
                
                Name = CourseNameInput.Text,
                Number = int.Parse(CourseNumberInput.Text),
                Credits = int.Parse(CreditsInput.Text),
                Department = DepartmentInput.Text
            };

            try
            {
                var CheckFilter = (from course in RegistrationClass.RegistrationEntities.Courses
                                   where course.Number == Number
                                   select course).ToList();


                if (CheckFilter.Count == 0)
                {
                    RegistrationClass.RegistrationEntities.Courses.Add(NewCourse);
                    RegistrationClass.RegistrationEntities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Record with that Course ID (number) already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please input new data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RegistrationClass.RegistrationEntities.Courses.Load();
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextBoxes()
        {
            
            CourseNameInput.Text = "";
            CourseNumberInput.Text = "";
            CreditsInput.Text = "";
            DepartmentInput.Text = "";
            DepartmentSearch.Text = "";
        }

        private void CourseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
