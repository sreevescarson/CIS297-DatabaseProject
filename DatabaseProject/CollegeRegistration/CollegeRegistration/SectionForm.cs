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
    public partial class SectionForm : Form
    {
        public SectionForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Sections.Load();
            SectionGrid.DataSource = RegistrationClass.RegistrationEntities.Sections.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Section NewSection = new Section
            {
                Id = int.Parse(IdInput.Text),
                CourseID = int.Parse(CourseIdInput.Text),
                FacultyID = int.Parse(FacultyIdInput.Text),
                Day = DayInput.Text,
                Time = TimeInput.Text,
                Semester = SemesterInput.Text
            };

            RegistrationClass.RegistrationEntities.Sections.Add(NewSection);
            RegistrationClass.RegistrationEntities.SaveChanges();
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SectionGrid.EndEdit();
            DataTable dataTable = new DataTable();
            SectionGrid.Update();
            RegistrationClass.RegistrationEntities.SaveChanges();

            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Section DeleteRecord = new Section();
            try
            {
                int DeleteID = int.Parse(IdInput.Text);

                DeleteRecord = (from sec in RegistrationClass.RegistrationEntities.Sections
                                where sec.Id == DeleteID
                                select sec).FirstOrDefault();

                RegistrationClass.RegistrationEntities.Sections.Remove(DeleteRecord);
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Cannot delete record due to <Input Error>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrationClass.RegistrationEntities.Sections.Load();
            }

            ClearTextBoxes();
        }
        
        private void FilterSemesterButton_Click(object sender, EventArgs e)
        {
            string findSection = FilterSemesterBox.Text;
            var SectionFilter = RegistrationClass.RegistrationEntities.Sections.Where(f => f.Semester == (findSection)).ToList();

            var list = new BindingList<Section>(SectionFilter);
            dataGridView3.DataSource = list;
            dataGridView3.Columns["Course"].Visible = false;
            dataGridView3.Columns["Enrollments"].Visible = false;
            dataGridView3.Columns["Faculty"].Visible = false;
          
            ClearTextBoxes();
        }

        private void SectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sectionDataset.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.sectionDataset.Section);
            // TODO: This line of code loads data into the 'registrationDataSet.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.registrationDataSet.Faculty);
            // TODO: This line of code loads data into the 'courseDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.courseDataSet.Course);

        }

        public void ClearTextBoxes()
        {
            IdInput.Text = "";
            CourseIdInput.Text = "";
            FacultyIdInput.Text = "";
            DayInput.Text = "";
            TimeInput.Text = "";
            SemesterInput.Text = "";
            FilterSemesterBox.Text = "";
        }
    }
}
