﻿using System;
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
    public partial class MajorForm : Form
    {
        public MajorForm()
        {
            InitializeComponent();
            RegistrationClass.RegistrationEntities.Students.Load();
            RegistrationClass.RegistrationEntities.Majors.Load();

            dataGridView1.DataSource = RegistrationClass.RegistrationEntities.Majors.Local.ToBindingList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MajorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet.Major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.registrationDataSet.Major);

        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Major NewMajor = new Major
            {
                Name = MajorNameInput.Text,
                College = CollegeInput.Text
            };

            RegistrationClass.RegistrationEntities.Majors.Add(NewMajor);
            RegistrationClass.RegistrationEntities.SaveChanges();
            ClearTextBoxes();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            dataGridView1.EndEdit();
            DataTable dataTable = new DataTable();
            dataGridView1.Update();
            RegistrationClass.RegistrationEntities.SaveChanges();

            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Major DeleteRecord = new Major();
            try
            {
                string DeleteName = MajorNameInput.Text;

                DeleteRecord = (from maj in RegistrationClass.RegistrationEntities.Majors
                                where maj.Name == DeleteName
                                select maj).FirstOrDefault();

                RegistrationClass.RegistrationEntities.Majors.Remove(DeleteRecord);
                RegistrationClass.RegistrationEntities.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Cannot delete record due because there is more than 0 students registered in that Major", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrationClass.RegistrationEntities.Majors.Load();
            }

            ClearTextBoxes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void ClearTextBoxes()
        {
            MajorNameInput.Text = "";
            CollegeInput.Text = "";
        }
    }
}
