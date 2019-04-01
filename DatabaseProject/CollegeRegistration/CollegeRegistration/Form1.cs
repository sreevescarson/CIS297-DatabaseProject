using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistration
{

    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void ToStudentFormButton_Click(object sender, EventArgs e)
        {
            var myForm = new StudentForm();
            myForm.Show();
        }

        private void ToMajorMenuButton_Click(object sender, EventArgs e)
        {
            var myForm1 = new MajorForm();
            myForm1.Show();
        }

        private void ToEnrollmentMenuButton_Click(object sender, EventArgs e)
        {
            var myForm2 = new EnrollmentForm();
            myForm2.Show();
        }

        private void ToCourseMenuButton_Click(object sender, EventArgs e)
        {
            var myForm3 = new CourseForm();
            myForm3.Show();
        }

        private void ToSectionMenuButton_Click(object sender, EventArgs e)
        {
            var myForm4 = new SectionForm();
            myForm4.Show();
        }

        private void ToFacultyMenuButton_Click(object sender, EventArgs e)
        {
            var myForm5 = new FacultyForm();
            myForm5.Show();
        }
    }
}
