namespace CollegeRegistration
{
    partial class EnrollmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EnrollmentGrid = new System.Windows.Forms.DataGridView();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSet = new CollegeRegistration.RegistrationDataSet();
            this.enrollmentTableAdapter = new CollegeRegistration.RegistrationDataSetTableAdapters.EnrollmentTableAdapter();
            this.FindStudentButton = new System.Windows.Forms.Button();
            this.FilterStudentBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.enrollmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new CollegeRegistration.RegistrationDataSetTableAdapters.CourseTableAdapter();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.majorTableAdapter = new CollegeRegistration.RegistrationDataSetTableAdapters.MajorTableAdapter();
            this.enrollmentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentSet = new CollegeRegistration.EnrollmentSet();
            this.enrollmentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentTableAdapter1 = new CollegeRegistration.EnrollmentSetTableAdapters.EnrollmentTableAdapter();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.SectionIdInput = new System.Windows.Forms.TextBox();
            this.GradeInput = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollmentStudentSet = new CollegeRegistration.EnrollmentStudentSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new CollegeRegistration.EnrollmentStudentSetTableAdapters.StudentTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.enrollmentSectionDataset = new CollegeRegistration.EnrollmentSectionDataset();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTableAdapter = new CollegeRegistration.EnrollmentSectionDatasetTableAdapters.SectionTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterStudentGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentStudentSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentSectionDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterStudentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EnrollmentGrid
            // 
            this.EnrollmentGrid.AutoGenerateColumns = false;
            this.EnrollmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.StudentID,
            this.SectionID,
            this.Grade});
            this.EnrollmentGrid.DataSource = this.enrollmentBindingSource4;
            this.EnrollmentGrid.Location = new System.Drawing.Point(12, 12);
            this.EnrollmentGrid.Name = "EnrollmentGrid";
            this.EnrollmentGrid.RowTemplate.Height = 31;
            this.EnrollmentGrid.Size = new System.Drawing.Size(814, 340);
            this.EnrollmentGrid.TabIndex = 0;
            this.EnrollmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.registrationDataSetBindingSource;
            // 
            // registrationDataSetBindingSource
            // 
            this.registrationDataSetBindingSource.DataSource = this.registrationDataSet;
            this.registrationDataSetBindingSource.Position = 0;
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // FindStudentButton
            // 
            this.FindStudentButton.Location = new System.Drawing.Point(13, 418);
            this.FindStudentButton.Name = "FindStudentButton";
            this.FindStudentButton.Size = new System.Drawing.Size(316, 41);
            this.FindStudentButton.TabIndex = 1;
            this.FindStudentButton.Text = "Filter Student (ID)";
            this.FindStudentButton.UseVisualStyleBackColor = true;
            this.FindStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterStudentBox
            // 
            this.FilterStudentBox.Location = new System.Drawing.Point(13, 373);
            this.FilterStudentBox.Name = "FilterStudentBox";
            this.FilterStudentBox.Size = new System.Drawing.Size(316, 29);
            this.FilterStudentBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(852, 174);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(186, 56);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // enrollmentBindingSource1
            // 
            this.enrollmentBindingSource1.DataMember = "Enrollment";
            this.enrollmentBindingSource1.DataSource = this.registrationDataSetBindingSource;
            // 
            // enrollmentBindingSource2
            // 
            this.enrollmentBindingSource2.DataMember = "Enrollment";
            this.enrollmentBindingSource2.DataSource = this.registrationDataSet;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.registrationDataSetBindingSource;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "Major";
            this.majorBindingSource.DataSource = this.registrationDataSetBindingSource;
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // enrollmentBindingSource3
            // 
            this.enrollmentBindingSource3.DataMember = "Enrollment";
            this.enrollmentBindingSource3.DataSource = this.registrationDataSetBindingSource;
            // 
            // enrollmentSet
            // 
            this.enrollmentSet.DataSetName = "EnrollmentSet";
            this.enrollmentSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentBindingSource4
            // 
            this.enrollmentBindingSource4.DataMember = "Enrollment";
            this.enrollmentBindingSource4.DataSource = this.enrollmentSet;
            // 
            // enrollmentTableAdapter1
            // 
            this.enrollmentTableAdapter1.ClearBeforeFill = true;
            // 
            // IdInput
            // 
            this.IdInput.Location = new System.Drawing.Point(1113, 12);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(298, 29);
            this.IdInput.TabIndex = 4;
            // 
            // SectionIdInput
            // 
            this.SectionIdInput.Location = new System.Drawing.Point(1113, 88);
            this.SectionIdInput.Name = "SectionIdInput";
            this.SectionIdInput.Size = new System.Drawing.Size(298, 29);
            this.SectionIdInput.TabIndex = 5;
            // 
            // GradeInput
            // 
            this.GradeInput.Location = new System.Drawing.Point(1113, 125);
            this.GradeInput.MaxLength = 2;
            this.GradeInput.Name = "GradeInput";
            this.GradeInput.Size = new System.Drawing.Size(298, 29);
            this.GradeInput.TabIndex = 6;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1044, 174);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(176, 56);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1225, 174);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 56);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SectionID
            // 
            this.SectionID.DataPropertyName = "SectionID";
            this.SectionID.HeaderText = "SectionID";
            this.SectionID.Name = "SectionID";
            this.SectionID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentIdInput
            // 
            this.StudentIdInput.Location = new System.Drawing.Point(1113, 49);
            this.StudentIdInput.Name = "StudentIdInput";
            this.StudentIdInput.Size = new System.Drawing.Size(298, 29);
            this.StudentIdInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Section ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(845, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Grade (Can Be Empty)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(847, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Student ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(933, 528);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(481, 199);
            this.dataGridView1.TabIndex = 14;
            // 
            // enrollmentStudentSet
            // 
            this.enrollmentStudentSet.DataSetName = "EnrollmentStudentSet";
            this.enrollmentStudentSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.enrollmentStudentSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.sectionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(933, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(481, 199);
            this.dataGridView2.TabIndex = 15;
            // 
            // enrollmentSectionDataset
            // 
            this.enrollmentSectionDataset.DataSetName = "EnrollmentSectionDataset";
            this.enrollmentSectionDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            this.sectionBindingSource.DataSource = this.enrollmentSectionDataset;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1133, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Student List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1133, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Section List";
            // 
            // FilterStudentGrid
            // 
            this.FilterStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterStudentGrid.Location = new System.Drawing.Point(13, 477);
            this.FilterStudentGrid.Name = "FilterStudentGrid";
            this.FilterStudentGrid.RowTemplate.Height = 31;
            this.FilterStudentGrid.Size = new System.Drawing.Size(813, 250);
            this.FilterStudentGrid.TabIndex = 18;
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1426, 739);
            this.Controls.Add(this.FilterStudentGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentIdInput);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.GradeInput);
            this.Controls.Add(this.SectionIdInput);
            this.Controls.Add(this.IdInput);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FilterStudentBox);
            this.Controls.Add(this.FindStudentButton);
            this.Controls.Add(this.EnrollmentGrid);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentStudentSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentSectionDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterStudentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EnrollmentGrid;
        private System.Windows.Forms.BindingSource registrationDataSetBindingSource;
        private RegistrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private RegistrationDataSetTableAdapters.EnrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.Button FindStudentButton;
        private System.Windows.Forms.TextBox FilterStudentBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource enrollmentBindingSource2;
        private System.Windows.Forms.BindingSource enrollmentBindingSource1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private RegistrationDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private RegistrationDataSetTableAdapters.MajorTableAdapter majorTableAdapter;
        private System.Windows.Forms.BindingSource enrollmentBindingSource3;
        private EnrollmentSet enrollmentSet;
        private System.Windows.Forms.BindingSource enrollmentBindingSource4;
        private EnrollmentSetTableAdapters.EnrollmentTableAdapter enrollmentTableAdapter1;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.TextBox SectionIdInput;
        private System.Windows.Forms.TextBox GradeInput;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.TextBox StudentIdInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EnrollmentStudentSet enrollmentStudentSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private EnrollmentStudentSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private EnrollmentSectionDataset enrollmentSectionDataset;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private EnrollmentSectionDatasetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView FilterStudentGrid;
    }
}