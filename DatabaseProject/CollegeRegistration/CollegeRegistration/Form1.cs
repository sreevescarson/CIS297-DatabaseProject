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

        private void AddStudentNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnrollmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Student NewStudent = new Student
            {
                Name = "Test",
                MajorID = 2,
            };

            RegistrationClass.RegistrationEntities.Students.Add(NewStudent);
            RegistrationClass.RegistrationEntities.SaveChanges();
            
        }

        private void ToStudentFormButton_Click(object sender, EventArgs e)
        {
            var myForm = new StudentForm();
            myForm.Show();
        }
    }
}
