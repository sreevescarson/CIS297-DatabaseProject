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
            this.registrationDataSet = new CollegeRegistration.RegistrationDataSet();
            this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentTableAdapter = new CollegeRegistration.RegistrationDataSetTableAdapters.EnrollmentTableAdapter();
            this.FindStudentButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EnrollmentStudentIDBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollmentCourseIDBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnrollmentGradeBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EnrollmentGrid
            // 
            this.EnrollmentGrid.AllowUserToOrderColumns = true;
            this.EnrollmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnrollmentStudentIDBox,
            this.EnrollmentCourseIDBox,
            this.EnrollmentGradeBox});
            this.EnrollmentGrid.Location = new System.Drawing.Point(586, 186);
            this.EnrollmentGrid.Name = "EnrollmentGrid";
            this.EnrollmentGrid.RowTemplate.Height = 31;
            this.EnrollmentGrid.Size = new System.Drawing.Size(419, 150);
            this.EnrollmentGrid.TabIndex = 0;
            this.EnrollmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationDataSetBindingSource
            // 
            this.registrationDataSetBindingSource.DataSource = this.registrationDataSet;
            this.registrationDataSetBindingSource.Position = 0;
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.registrationDataSetBindingSource;
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // FindStudentButton
            // 
            this.FindStudentButton.Location = new System.Drawing.Point(586, 407);
            this.FindStudentButton.Name = "FindStudentButton";
            this.FindStudentButton.Size = new System.Drawing.Size(140, 41);
            this.FindStudentButton.TabIndex = 1;
            this.FindStudentButton.Text = "Find Student";
            this.FindStudentButton.UseVisualStyleBackColor = true;
            this.FindStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 29);
            this.textBox1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(586, 479);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 40);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // EnrollmentStudentIDBox
            // 
            this.EnrollmentStudentIDBox.HeaderText = "StudentID";
            this.EnrollmentStudentIDBox.Name = "EnrollmentStudentIDBox";
            this.EnrollmentStudentIDBox.ReadOnly = true;
            this.EnrollmentStudentIDBox.Width = 125;
            // 
            // EnrollmentCourseIDBox
            // 
            this.EnrollmentCourseIDBox.HeaderText = "CourseID";
            this.EnrollmentCourseIDBox.Name = "EnrollmentCourseIDBox";
            this.EnrollmentCourseIDBox.ReadOnly = true;
            this.EnrollmentCourseIDBox.Width = 125;
            // 
            // EnrollmentGradeBox
            // 
            this.EnrollmentGradeBox.HeaderText = "Grade";
            this.EnrollmentGradeBox.Name = "EnrollmentGradeBox";
            this.EnrollmentGradeBox.Width = 125;
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 700);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FindStudentButton);
            this.Controls.Add(this.EnrollmentGrid);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollmentStudentIDBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollmentCourseIDBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnrollmentGradeBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveButton;
    }
}