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
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Enrollments.Load();
            EnrollmentGrid.DataSource = RegistrationClass.RegistrationEntities.Enrollments.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enrollmentSectionSemesterDatasource.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter2.Fill(this.enrollmentSectionSemesterDatasource.Section);
            // TODO: This line of code loads data into the 'sectionDataset.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter1.Fill(this.sectionDataset.Section);
            // TODO: This line of code loads data into the 'enrollmentSectionDataset.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.enrollmentSectionDataset.Section);
            // TODO: This line of code loads data into the 'enrollmentStudentSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.enrollmentStudentSet.Student);
            // TODO: This line of code loads data into the 'enrollmentSet.Enrollment' table. You can move, or remove it, as needed.
            this.enrollmentTableAdapter1.Fill(this.enrollmentSet.Enrollment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search by semester and student ID
            int findStudent = int.Parse(FilterStudentBox.Text);
            var StudentFilter = RegistrationClass.RegistrationEntities.Enrollments.Where(f => f.StudentID == (findStudent) && f.Section.Semester == (SemesterInput.Text) ).ToList();

            var list = new BindingList<Enrollment>(StudentFilter);
            FilterStudentGrid.DataSource = list;
            FilterStudentGrid.Columns["Section"].Visible = false;
            FilterStudentGrid.Columns["Student"].Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(IdInput.Text);
            int StudentID = int.Parse(StudentIdInput.Text);
            int SectionID = int.Parse(SectionIdInput.Text);
            string Grade = GradeInput.Text;

            Enrollment NewEnrollment = new Enrollment
            {
                Id = int.Parse(IdInput.Text),
                StudentID = int.Parse(StudentIdInput.Text),
                SectionID = int.Parse(SectionIdInput.Text),
                Grade = GradeInput.Text
            };

            try
            {
                //extra credit for Semester + studentID filter
                var CheckFilter = (from enroll in RegistrationClass.RegistrationEntities.Enrollments
                                   where enroll.SectionID == SectionID
                                   where enroll.StudentID == StudentID
                                   select enroll).ToList();


                if (CheckFilter.Count == 0)
                {
                    RegistrationClass.RegistrationEntities.Enrollments.Add(NewEnrollment);
                    RegistrationClass.RegistrationEntities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Record with that Student ID and Section ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please input new data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RegistrationClass.RegistrationEntities.Enrollments.Load();
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                EnrollmentGrid.EndEdit();
                DataTable dataTable = new DataTable();
                EnrollmentGrid.Update();
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Please use a valid Section and Student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("Name cannot be Null or over 50 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Enrollment DeleteRecord = new Enrollment();
            try
            {
                string DeleteID = IdInput.Text;
                int DeleteIntId = int.Parse(DeleteID);

                DeleteRecord = (from enroll in RegistrationClass.RegistrationEntities.Enrollments
                                where enroll.Id == DeleteIntId
                                select enroll).FirstOrDefault();

                RegistrationClass.RegistrationEntities.Enrollments.Remove(DeleteRecord);
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Cannot delete record due to current and/or prior enrollments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrationClass.RegistrationEntities.Enrollments.Load();
            }

            ClearTextBoxes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextBoxes()
        {
            FilterStudentBox.Text = "";
            IdInput.Text = "";
            StudentIdInput.Text = "";
            SectionIdInput.Text = "";
            GradeInput.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
