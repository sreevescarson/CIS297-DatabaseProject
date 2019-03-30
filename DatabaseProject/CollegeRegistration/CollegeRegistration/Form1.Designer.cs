namespace CollegeRegistration
{
    partial class Form1
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
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.FacultyListBox = new System.Windows.Forms.ListBox();
            this.MajorListBox = new System.Windows.Forms.ListBox();
            this.SectionListBox = new System.Windows.Forms.ListBox();
            this.EnrollmentListBox = new System.Windows.Forms.ListBox();
            this.AddStudentNameTextbox = new System.Windows.Forms.TextBox();
            this.AddCourseNameTextbox = new System.Windows.Forms.TextBox();
            this.AddFacultyNameTextbox = new System.Windows.Forms.TextBox();
            this.AddMajorNameTextbox = new System.Windows.Forms.TextBox();
            this.AddSectionDayTextbox = new System.Windows.Forms.TextBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.AddFacultyButton = new System.Windows.Forms.Button();
            this.AddMajorButton = new System.Windows.Forms.Button();
            this.AddSectionButton = new System.Windows.Forms.Button();
            this.AddEnrollmentButton = new System.Windows.Forms.Button();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.RemoveCourseButton = new System.Windows.Forms.Button();
            this.RemoveFacultyButton = new System.Windows.Forms.Button();
            this.RemoveMajorButton = new System.Windows.Forms.Button();
            this.RemoveSectionButton = new System.Windows.Forms.Button();
            this.RemoveEnrollmentButton = new System.Windows.Forms.Button();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.MajorLabel = new System.Windows.Forms.Label();
            this.SectionLabel = new System.Windows.Forms.Label();
            this.EnrollmentLabel = new System.Windows.Forms.Label();
            this.AddMajorCollegeTextbox = new System.Windows.Forms.TextBox();
            this.AddCourseNumberTextbox = new System.Windows.Forms.TextBox();
            this.AddCourseDepartmentTextbox = new System.Windows.Forms.TextBox();
            this.AddFacultyPhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.AddSectionTimeTextbox = new System.Windows.Forms.TextBox();
            this.AddSectionSemesterTextbox = new System.Windows.Forms.TextBox();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.FacultyNameLabel = new System.Windows.Forms.Label();
            this.FacultyPhoneNumberLabel = new System.Windows.Forms.Label();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseNumberLabel = new System.Windows.Forms.Label();
            this.CourseDepartmentLabel = new System.Windows.Forms.Label();
            this.MajorNameLabel = new System.Windows.Forms.Label();
            this.MajorCollegeLabel = new System.Windows.Forms.Label();
            this.SectionDayLabel = new System.Windows.Forms.Label();
            this.SectionTimeLabel = new System.Windows.Forms.Label();
            this.SectionSemesterLabel = new System.Windows.Forms.Label();
            this.ToStudentFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(62, 111);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(120, 95);
            this.StudentListBox.TabIndex = 0;
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.Location = new System.Drawing.Point(65, 356);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(120, 95);
            this.CourseListBox.TabIndex = 1;
            // 
            // FacultyListBox
            // 
            this.FacultyListBox.FormattingEnabled = true;
            this.FacultyListBox.Location = new System.Drawing.Point(337, 111);
            this.FacultyListBox.Name = "FacultyListBox";
            this.FacultyListBox.Size = new System.Drawing.Size(120, 95);
            this.FacultyListBox.TabIndex = 2;
            // 
            // MajorListBox
            // 
            this.MajorListBox.FormattingEnabled = true;
            this.MajorListBox.Location = new System.Drawing.Point(585, 111);
            this.MajorListBox.Name = "MajorListBox";
            this.MajorListBox.Size = new System.Drawing.Size(120, 95);
            this.MajorListBox.TabIndex = 3;
            // 
            // SectionListBox
            // 
            this.SectionListBox.FormattingEnabled = true;
            this.SectionListBox.Location = new System.Drawing.Point(358, 356);
            this.SectionListBox.Name = "SectionListBox";
            this.SectionListBox.Size = new System.Drawing.Size(120, 95);
            this.SectionListBox.TabIndex = 4;
            // 
            // EnrollmentListBox
            // 
            this.EnrollmentListBox.FormattingEnabled = true;
            this.EnrollmentListBox.Location = new System.Drawing.Point(1081, 111);
            this.EnrollmentListBox.Name = "EnrollmentListBox";
            this.EnrollmentListBox.Size = new System.Drawing.Size(120, 95);
            this.EnrollmentListBox.TabIndex = 5;
            this.EnrollmentListBox.SelectedIndexChanged += new System.EventHandler(this.EnrollmentListBox_SelectedIndexChanged);
            // 
            // AddStudentNameTextbox
            // 
            this.AddStudentNameTextbox.Location = new System.Drawing.Point(62, 85);
            this.AddStudentNameTextbox.Name = "AddStudentNameTextbox";
            this.AddStudentNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddStudentNameTextbox.TabIndex = 6;
            this.AddStudentNameTextbox.TextChanged += new System.EventHandler(this.AddStudentNameTextbox_TextChanged);
            // 
            // AddCourseNameTextbox
            // 
            this.AddCourseNameTextbox.Location = new System.Drawing.Point(65, 286);
            this.AddCourseNameTextbox.Name = "AddCourseNameTextbox";
            this.AddCourseNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddCourseNameTextbox.TabIndex = 7;
            // 
            // AddFacultyNameTextbox
            // 
            this.AddFacultyNameTextbox.Location = new System.Drawing.Point(337, 63);
            this.AddFacultyNameTextbox.Name = "AddFacultyNameTextbox";
            this.AddFacultyNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddFacultyNameTextbox.TabIndex = 8;
            // 
            // AddMajorNameTextbox
            // 
            this.AddMajorNameTextbox.Location = new System.Drawing.Point(585, 61);
            this.AddMajorNameTextbox.Name = "AddMajorNameTextbox";
            this.AddMajorNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddMajorNameTextbox.TabIndex = 9;
            // 
            // AddSectionDayTextbox
            // 
            this.AddSectionDayTextbox.Location = new System.Drawing.Point(358, 286);
            this.AddSectionDayTextbox.Name = "AddSectionDayTextbox";
            this.AddSectionDayTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddSectionDayTextbox.TabIndex = 10;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(169, 85);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(75, 23);
            this.AddStudentButton.TabIndex = 11;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(172, 330);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 12;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // AddFacultyButton
            // 
            this.AddFacultyButton.Location = new System.Drawing.Point(443, 83);
            this.AddFacultyButton.Name = "AddFacultyButton";
            this.AddFacultyButton.Size = new System.Drawing.Size(75, 23);
            this.AddFacultyButton.TabIndex = 13;
            this.AddFacultyButton.Text = "Add Faculty";
            this.AddFacultyButton.UseVisualStyleBackColor = true;
            // 
            // AddMajorButton
            // 
            this.AddMajorButton.Location = new System.Drawing.Point(691, 85);
            this.AddMajorButton.Name = "AddMajorButton";
            this.AddMajorButton.Size = new System.Drawing.Size(75, 23);
            this.AddMajorButton.TabIndex = 14;
            this.AddMajorButton.Text = "Add Major";
            this.AddMajorButton.UseVisualStyleBackColor = true;
            // 
            // AddSectionButton
            // 
            this.AddSectionButton.Location = new System.Drawing.Point(464, 328);
            this.AddSectionButton.Name = "AddSectionButton";
            this.AddSectionButton.Size = new System.Drawing.Size(75, 23);
            this.AddSectionButton.TabIndex = 15;
            this.AddSectionButton.Text = "Add Section";
            this.AddSectionButton.UseVisualStyleBackColor = true;
            // 
            // AddEnrollmentButton
            // 
            this.AddEnrollmentButton.Location = new System.Drawing.Point(1081, 84);
            this.AddEnrollmentButton.Name = "AddEnrollmentButton";
            this.AddEnrollmentButton.Size = new System.Drawing.Size(120, 23);
            this.AddEnrollmentButton.TabIndex = 16;
            this.AddEnrollmentButton.Text = "Add Enrollment";
            this.AddEnrollmentButton.UseVisualStyleBackColor = true;
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Location = new System.Drawing.Point(62, 213);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveStudentButton.TabIndex = 17;
            this.RemoveStudentButton.Text = "Remove Student";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            // 
            // RemoveCourseButton
            // 
            this.RemoveCourseButton.Location = new System.Drawing.Point(65, 458);
            this.RemoveCourseButton.Name = "RemoveCourseButton";
            this.RemoveCourseButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveCourseButton.TabIndex = 18;
            this.RemoveCourseButton.Text = "Remove Course";
            this.RemoveCourseButton.UseVisualStyleBackColor = true;
            // 
            // RemoveFacultyButton
            // 
            this.RemoveFacultyButton.Location = new System.Drawing.Point(337, 213);
            this.RemoveFacultyButton.Name = "RemoveFacultyButton";
            this.RemoveFacultyButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveFacultyButton.TabIndex = 19;
            this.RemoveFacultyButton.Text = "Remove Faculty";
            this.RemoveFacultyButton.UseVisualStyleBackColor = true;
            // 
            // RemoveMajorButton
            // 
            this.RemoveMajorButton.Location = new System.Drawing.Point(585, 213);
            this.RemoveMajorButton.Name = "RemoveMajorButton";
            this.RemoveMajorButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveMajorButton.TabIndex = 20;
            this.RemoveMajorButton.Text = "Remove Major";
            this.RemoveMajorButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSectionButton
            // 
            this.RemoveSectionButton.Location = new System.Drawing.Point(358, 458);
            this.RemoveSectionButton.Name = "RemoveSectionButton";
            this.RemoveSectionButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveSectionButton.TabIndex = 21;
            this.RemoveSectionButton.Text = "Remove Section";
            this.RemoveSectionButton.UseVisualStyleBackColor = true;
            // 
            // RemoveEnrollmentButton
            // 
            this.RemoveEnrollmentButton.Location = new System.Drawing.Point(1081, 213);
            this.RemoveEnrollmentButton.Name = "RemoveEnrollmentButton";
            this.RemoveEnrollmentButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveEnrollmentButton.TabIndex = 22;
            this.RemoveEnrollmentButton.Text = "Remove Enrollment";
            this.RemoveEnrollmentButton.UseVisualStyleBackColor = true;
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(62, 66);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(44, 13);
            this.StudentLabel.TabIndex = 23;
            this.StudentLabel.Text = "Student";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(62, 270);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(40, 13);
            this.CourseLabel.TabIndex = 24;
            this.CourseLabel.Text = "Course";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(334, 40);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(41, 13);
            this.FacultyLabel.TabIndex = 25;
            this.FacultyLabel.Text = "Faculty";
            // 
            // MajorLabel
            // 
            this.MajorLabel.AutoSize = true;
            this.MajorLabel.Location = new System.Drawing.Point(582, 40);
            this.MajorLabel.Name = "MajorLabel";
            this.MajorLabel.Size = new System.Drawing.Size(33, 13);
            this.MajorLabel.TabIndex = 26;
            this.MajorLabel.Text = "Major";
            // 
            // SectionLabel
            // 
            this.SectionLabel.AutoSize = true;
            this.SectionLabel.Location = new System.Drawing.Point(355, 270);
            this.SectionLabel.Name = "SectionLabel";
            this.SectionLabel.Size = new System.Drawing.Size(43, 13);
            this.SectionLabel.TabIndex = 27;
            this.SectionLabel.Text = "Section";
            // 
            // EnrollmentLabel
            // 
            this.EnrollmentLabel.AutoSize = true;
            this.EnrollmentLabel.Location = new System.Drawing.Point(1078, 68);
            this.EnrollmentLabel.Name = "EnrollmentLabel";
            this.EnrollmentLabel.Size = new System.Drawing.Size(56, 13);
            this.EnrollmentLabel.TabIndex = 28;
            this.EnrollmentLabel.Text = "Enrollment";
            // 
            // AddMajorCollegeTextbox
            // 
            this.AddMajorCollegeTextbox.Location = new System.Drawing.Point(585, 88);
            this.AddMajorCollegeTextbox.Name = "AddMajorCollegeTextbox";
            this.AddMajorCollegeTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddMajorCollegeTextbox.TabIndex = 29;
            // 
            // AddCourseNumberTextbox
            // 
            this.AddCourseNumberTextbox.Location = new System.Drawing.Point(65, 308);
            this.AddCourseNumberTextbox.Name = "AddCourseNumberTextbox";
            this.AddCourseNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddCourseNumberTextbox.TabIndex = 30;
            // 
            // AddCourseDepartmentTextbox
            // 
            this.AddCourseDepartmentTextbox.Location = new System.Drawing.Point(66, 330);
            this.AddCourseDepartmentTextbox.Name = "AddCourseDepartmentTextbox";
            this.AddCourseDepartmentTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddCourseDepartmentTextbox.TabIndex = 31;
            // 
            // AddFacultyPhoneNumberTextbox
            // 
            this.AddFacultyPhoneNumberTextbox.Location = new System.Drawing.Point(337, 84);
            this.AddFacultyPhoneNumberTextbox.Name = "AddFacultyPhoneNumberTextbox";
            this.AddFacultyPhoneNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddFacultyPhoneNumberTextbox.TabIndex = 32;
            // 
            // AddSectionTimeTextbox
            // 
            this.AddSectionTimeTextbox.Location = new System.Drawing.Point(358, 308);
            this.AddSectionTimeTextbox.Name = "AddSectionTimeTextbox";
            this.AddSectionTimeTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddSectionTimeTextbox.TabIndex = 33;
            // 
            // AddSectionSemesterTextbox
            // 
            this.AddSectionSemesterTextbox.Location = new System.Drawing.Point(358, 330);
            this.AddSectionSemesterTextbox.Name = "AddSectionSemesterTextbox";
            this.AddSectionSemesterTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddSectionSemesterTextbox.TabIndex = 34;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(21, 89);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.StudentNameLabel.TabIndex = 35;
            this.StudentNameLabel.Text = "Name";
            // 
            // FacultyNameLabel
            // 
            this.FacultyNameLabel.AutoSize = true;
            this.FacultyNameLabel.Location = new System.Drawing.Point(285, 69);
            this.FacultyNameLabel.Name = "FacultyNameLabel";
            this.FacultyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.FacultyNameLabel.TabIndex = 36;
            this.FacultyNameLabel.Text = "Name";
            // 
            // FacultyPhoneNumberLabel
            // 
            this.FacultyPhoneNumberLabel.AutoSize = true;
            this.FacultyPhoneNumberLabel.Location = new System.Drawing.Point(253, 90);
            this.FacultyPhoneNumberLabel.Name = "FacultyPhoneNumberLabel";
            this.FacultyPhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.FacultyPhoneNumberLabel.TabIndex = 37;
            this.FacultyPhoneNumberLabel.Text = "Phone Number";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(24, 293);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CourseNameLabel.TabIndex = 38;
            this.CourseNameLabel.Text = "Name";
            // 
            // CourseNumberLabel
            // 
            this.CourseNumberLabel.AutoSize = true;
            this.CourseNumberLabel.Location = new System.Drawing.Point(15, 311);
            this.CourseNumberLabel.Name = "CourseNumberLabel";
            this.CourseNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.CourseNumberLabel.TabIndex = 39;
            this.CourseNumberLabel.Text = "Number";
            // 
            // CourseDepartmentLabel
            // 
            this.CourseDepartmentLabel.AutoSize = true;
            this.CourseDepartmentLabel.Location = new System.Drawing.Point(-2, 335);
            this.CourseDepartmentLabel.Name = "CourseDepartmentLabel";
            this.CourseDepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.CourseDepartmentLabel.TabIndex = 40;
            this.CourseDepartmentLabel.Text = "Department";
            // 
            // MajorNameLabel
            // 
            this.MajorNameLabel.AutoSize = true;
            this.MajorNameLabel.Location = new System.Drawing.Point(544, 61);
            this.MajorNameLabel.Name = "MajorNameLabel";
            this.MajorNameLabel.Size = new System.Drawing.Size(35, 13);
            this.MajorNameLabel.TabIndex = 41;
            this.MajorNameLabel.Text = "Name";
            // 
            // MajorCollegeLabel
            // 
            this.MajorCollegeLabel.AutoSize = true;
            this.MajorCollegeLabel.Location = new System.Drawing.Point(537, 92);
            this.MajorCollegeLabel.Name = "MajorCollegeLabel";
            this.MajorCollegeLabel.Size = new System.Drawing.Size(42, 13);
            this.MajorCollegeLabel.TabIndex = 42;
            this.MajorCollegeLabel.Text = "College";
            // 
            // SectionDayLabel
            // 
            this.SectionDayLabel.AutoSize = true;
            this.SectionDayLabel.Location = new System.Drawing.Point(317, 289);
            this.SectionDayLabel.Name = "SectionDayLabel";
            this.SectionDayLabel.Size = new System.Drawing.Size(26, 13);
            this.SectionDayLabel.TabIndex = 43;
            this.SectionDayLabel.Text = "Day";
            // 
            // SectionTimeLabel
            // 
            this.SectionTimeLabel.AutoSize = true;
            this.SectionTimeLabel.Location = new System.Drawing.Point(317, 315);
            this.SectionTimeLabel.Name = "SectionTimeLabel";
            this.SectionTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.SectionTimeLabel.TabIndex = 44;
            this.SectionTimeLabel.Text = "Time";
            // 
            // SectionSemesterLabel
            // 
            this.SectionSemesterLabel.AutoSize = true;
            this.SectionSemesterLabel.Location = new System.Drawing.Point(301, 335);
            this.SectionSemesterLabel.Name = "SectionSemesterLabel";
            this.SectionSemesterLabel.Size = new System.Drawing.Size(51, 13);
            this.SectionSemesterLabel.TabIndex = 45;
            this.SectionSemesterLabel.Text = "Semester";
            // 
            // ToStudentFormButton
            // 
            this.ToStudentFormButton.Location = new System.Drawing.Point(815, 300);
            this.ToStudentFormButton.Name = "ToStudentFormButton";
            this.ToStudentFormButton.Size = new System.Drawing.Size(107, 24);
            this.ToStudentFormButton.TabIndex = 46;
            this.ToStudentFormButton.Text = "Student Menu";
            this.ToStudentFormButton.UseVisualStyleBackColor = true;
            this.ToStudentFormButton.Click += new System.EventHandler(this.ToStudentFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 562);
            this.Controls.Add(this.ToStudentFormButton);
            this.Controls.Add(this.SectionSemesterLabel);
            this.Controls.Add(this.SectionTimeLabel);
            this.Controls.Add(this.SectionDayLabel);
            this.Controls.Add(this.MajorCollegeLabel);
            this.Controls.Add(this.MajorNameLabel);
            this.Controls.Add(this.CourseDepartmentLabel);
            this.Controls.Add(this.CourseNumberLabel);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.FacultyPhoneNumberLabel);
            this.Controls.Add(this.FacultyNameLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.AddSectionSemesterTextbox);
            this.Controls.Add(this.AddSectionTimeTextbox);
            this.Controls.Add(this.AddFacultyPhoneNumberTextbox);
            this.Controls.Add(this.AddCourseDepartmentTextbox);
            this.Controls.Add(this.AddCourseNumberTextbox);
            this.Controls.Add(this.AddMajorCollegeTextbox);
            this.Controls.Add(this.EnrollmentLabel);
            this.Controls.Add(this.SectionLabel);
            this.Controls.Add(this.MajorLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.RemoveEnrollmentButton);
            this.Controls.Add(this.RemoveSectionButton);
            this.Controls.Add(this.RemoveMajorButton);
            this.Controls.Add(this.RemoveFacultyButton);
            this.Controls.Add(this.RemoveCourseButton);
            this.Controls.Add(this.RemoveStudentButton);
            this.Controls.Add(this.AddEnrollmentButton);
            this.Controls.Add(this.AddSectionButton);
            this.Controls.Add(this.AddMajorButton);
            this.Controls.Add(this.AddFacultyButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.AddSectionDayTextbox);
            this.Controls.Add(this.AddMajorNameTextbox);
            this.Controls.Add(this.AddFacultyNameTextbox);
            this.Controls.Add(this.AddCourseNameTextbox);
            this.Controls.Add(this.AddStudentNameTextbox);
            this.Controls.Add(this.EnrollmentListBox);
            this.Controls.Add(this.SectionListBox);
            this.Controls.Add(this.MajorListBox);
            this.Controls.Add(this.FacultyListBox);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.StudentListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.ListBox FacultyListBox;
        private System.Windows.Forms.ListBox MajorListBox;
        private System.Windows.Forms.ListBox SectionListBox;
        private System.Windows.Forms.ListBox EnrollmentListBox;
        private System.Windows.Forms.TextBox AddStudentNameTextbox;
        private System.Windows.Forms.TextBox AddCourseNameTextbox;
        private System.Windows.Forms.TextBox AddFacultyNameTextbox;
        private System.Windows.Forms.TextBox AddMajorNameTextbox;
        private System.Windows.Forms.TextBox AddSectionDayTextbox;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button AddFacultyButton;
        private System.Windows.Forms.Button AddMajorButton;
        private System.Windows.Forms.Button AddSectionButton;
        private System.Windows.Forms.Button AddEnrollmentButton;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.Button RemoveCourseButton;
        private System.Windows.Forms.Button RemoveFacultyButton;
        private System.Windows.Forms.Button RemoveMajorButton;
        private System.Windows.Forms.Button RemoveSectionButton;
        private System.Windows.Forms.Button RemoveEnrollmentButton;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label MajorLabel;
        private System.Windows.Forms.Label SectionLabel;
        private System.Windows.Forms.Label EnrollmentLabel;
        private System.Windows.Forms.TextBox AddMajorCollegeTextbox;
        private System.Windows.Forms.TextBox AddCourseNumberTextbox;
        private System.Windows.Forms.TextBox AddCourseDepartmentTextbox;
        private System.Windows.Forms.TextBox AddFacultyPhoneNumberTextbox;
        private System.Windows.Forms.TextBox AddSectionTimeTextbox;
        private System.Windows.Forms.TextBox AddSectionSemesterTextbox;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label FacultyNameLabel;
        private System.Windows.Forms.Label FacultyPhoneNumberLabel;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseNumberLabel;
        private System.Windows.Forms.Label CourseDepartmentLabel;
        private System.Windows.Forms.Label MajorNameLabel;
        private System.Windows.Forms.Label MajorCollegeLabel;
        private System.Windows.Forms.Label SectionDayLabel;
        private System.Windows.Forms.Label SectionTimeLabel;
        private System.Windows.Forms.Label SectionSemesterLabel;
        private System.Windows.Forms.Button ToStudentFormButton;
    }
}

