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
            GradeSectionInput.Text = "";
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            //extra credit
            try
            {
                int findSection = int.Parse(GradeSectionInput.Text);
                var SectionFilter = RegistrationClass.RegistrationEntities.Enrollments.Where(f => f.SectionID == (findSection)).ToList();
                double aPlus = 0;
                double a = 0;
                double aMinus = 0;
                double bPlus = 0;
                double b = 0;
                double bMinus = 0;
                double cPlus = 0;
                double c = 0;
                double cMinus = 0;
                double dPlus = 0;
                double d = 0;
                double dMinus = 0;
                double fail = 0;


                var list = new BindingList<Enrollment>(SectionFilter);

                double listCount = list.Count;
                for (int i = 0; i < listCount; i++)
                {
                    string SectionGrade = list.ElementAt(i).Grade;
                    switch (SectionGrade)
                    {
                        case "A+":
                            aPlus++;
                            break;
                        case "A":
                            a++;
                            break;
                        case "A-":
                            aMinus++;
                            break;
                        case "B+":
                            bPlus++;
                            break;
                        case "B":
                            b++;
                            break;
                        case "B-":
                            bMinus++;
                            break;
                        case "C+":
                            cPlus++;
                            break;
                        case "C":
                            c++;
                            break;
                        case "C-":
                            cMinus++;
                            break;
                        case "D+":
                            dPlus++;
                            break;
                        case "D":
                            d++;
                            break;
                        case "D-":
                            dMinus++;
                            break;
                        case "E":
                            fail++;
                            break;
                    }


                }

                double gradeAPlus = aPlus / listCount;
                double gradeA = a / listCount;
                double gradeAMinus = aMinus / listCount;
                double gradeBPlus = bPlus / listCount;
                double gradeB = b / listCount;
                double gradeBMinus = bMinus / listCount;
                double gradeCPlus = cPlus / listCount;
                double gradeC = c / listCount;
                double gradeCMinus = cMinus / listCount;
                double gradeDPlus = dPlus / listCount;
                double gradeD = d / listCount;
                double gradeDMinus = dMinus / listCount;
                double gradeFail = fail / listCount;
                int k = 0;

                List<string> GradeList = new List<string>();


                if (gradeAPlus > 0)
                    GradeList.Add("A+ " + gradeAPlus.ToString("#0.##%"));
                if (gradeA > 0)
                    GradeList.Add("A " + gradeA.ToString("#0.##%"));
                if (gradeAMinus > 0)
                    GradeList.Add("A- " + gradeAMinus.ToString("#0.##%"));
                if (gradeBPlus > 0)
                    GradeList.Add("B+ " + gradeBPlus.ToString("#0.##%"));
                if (gradeB > 0)
                    GradeList.Add("B " + gradeB.ToString("#0.##%"));
                if (gradeBMinus > 0)
                    GradeList.Add("B- " + gradeBMinus.ToString("#0.##%"));
                if (gradeCPlus > 0)
                    GradeList.Add("C+ " + gradeCPlus.ToString("#0.##%"));
                if (gradeC > 0)
                    GradeList.Add("C " + gradeC.ToString("#0.##%"));
                if (gradeCMinus > 0)
                    GradeList.Add("C- " + gradeCMinus.ToString("#0.##%"));
                if (gradeDPlus > 0)
                    GradeList.Add("D+ " + gradeDPlus.ToString("#0.##%"));
                if (gradeD > 0)
                    GradeList.Add("D " + gradeD.ToString("#0.##%"));
                if (gradeDMinus > 0)
                    GradeList.Add("D- " + gradeDMinus.ToString("#0.##%"));
                if (gradeFail > 0)
                    GradeList.Add("E " + gradeFail.ToString("#0.##%"));

                GradeDisplay.DataSource = GradeList;

                MessageBox.Show("Thank you for the extra credit :)", "You guys did a Fantastic Job!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearTextBoxes();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Cannot show grade percentage due to invalid Input (Section ID Only)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
