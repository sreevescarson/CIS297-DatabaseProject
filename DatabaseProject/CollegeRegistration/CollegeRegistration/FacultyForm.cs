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
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Faculties.Load();
            FacultyGrid.DataSource = RegistrationClass.RegistrationEntities.Faculties.Local.ToBindingList();
        }

        private void SaveFacultyButton_Click(object sender, EventArgs e)
        {
            Faculty NewFaculty = new Faculty
            {
                Name = FacultyNameInput.Text,
                PhoneNumber = PhoneNumberInput.Text
            };

            RegistrationClass.RegistrationEntities.Faculties.Add(NewFaculty);
            RegistrationClass.RegistrationEntities.SaveChanges();
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FacultyGrid.EndEdit();
            DataTable dataTable = new DataTable();
            FacultyGrid.Update();
            RegistrationClass.RegistrationEntities.SaveChanges();

            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Faculty DeleteRecord = new Faculty();
            try
            {
                string DeleteName = FacultyNameInput.Text;

                DeleteRecord = (from fac in RegistrationClass.RegistrationEntities.Faculties
                                where fac.Name == DeleteName
                                select fac).FirstOrDefault();

                RegistrationClass.RegistrationEntities.Faculties.Remove(DeleteRecord);
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Cannot delete record due to <Input Error>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrationClass.RegistrationEntities.Faculties.Load();
            }

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            PhoneNumberInput.Text = "";
            FacultyNameInput.Text = "";
        }

        private void FacultyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet1.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.registrationDataSet1.Faculty);

        }
    }
}
