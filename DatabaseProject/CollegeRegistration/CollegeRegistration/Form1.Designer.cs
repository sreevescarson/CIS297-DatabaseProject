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
            this.ToStudentFormButton = new System.Windows.Forms.Button();
            this.ToMajorMenuButton = new System.Windows.Forms.Button();
            this.ToEnrollmentMenuButton = new System.Windows.Forms.Button();
            this.ToCourseMenuButton = new System.Windows.Forms.Button();
            this.ToSectionMenuButton = new System.Windows.Forms.Button();
            this.ToFacultyMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToStudentFormButton
            // 
            this.ToStudentFormButton.Location = new System.Drawing.Point(12, 12);
            this.ToStudentFormButton.Name = "ToStudentFormButton";
            this.ToStudentFormButton.Size = new System.Drawing.Size(242, 36);
            this.ToStudentFormButton.TabIndex = 46;
            this.ToStudentFormButton.Text = "Student Menu";
            this.ToStudentFormButton.UseVisualStyleBackColor = true;
            this.ToStudentFormButton.Click += new System.EventHandler(this.ToStudentFormButton_Click);
            // 
            // ToMajorMenuButton
            // 
            this.ToMajorMenuButton.Location = new System.Drawing.Point(12, 54);
            this.ToMajorMenuButton.Name = "ToMajorMenuButton";
            this.ToMajorMenuButton.Size = new System.Drawing.Size(242, 38);
            this.ToMajorMenuButton.TabIndex = 47;
            this.ToMajorMenuButton.Text = "Major Menu";
            this.ToMajorMenuButton.UseVisualStyleBackColor = true;
            // 
            // ToEnrollmentMenuButton
            // 
            this.ToEnrollmentMenuButton.Location = new System.Drawing.Point(12, 98);
            this.ToEnrollmentMenuButton.Name = "ToEnrollmentMenuButton";
            this.ToEnrollmentMenuButton.Size = new System.Drawing.Size(242, 38);
            this.ToEnrollmentMenuButton.TabIndex = 48;
            this.ToEnrollmentMenuButton.Text = "Enrollment Menu";
            this.ToEnrollmentMenuButton.UseVisualStyleBackColor = true;
            // 
            // ToCourseMenuButton
            // 
            this.ToCourseMenuButton.Location = new System.Drawing.Point(12, 142);
            this.ToCourseMenuButton.Name = "ToCourseMenuButton";
            this.ToCourseMenuButton.Size = new System.Drawing.Size(242, 38);
            this.ToCourseMenuButton.TabIndex = 49;
            this.ToCourseMenuButton.Text = "Course Menu";
            this.ToCourseMenuButton.UseVisualStyleBackColor = true;
            // 
            // ToSectionMenuButton
            // 
            this.ToSectionMenuButton.Location = new System.Drawing.Point(12, 186);
            this.ToSectionMenuButton.Name = "ToSectionMenuButton";
            this.ToSectionMenuButton.Size = new System.Drawing.Size(242, 38);
            this.ToSectionMenuButton.TabIndex = 50;
            this.ToSectionMenuButton.Text = "Section Menu";
            this.ToSectionMenuButton.UseVisualStyleBackColor = true;
            // 
            // ToFacultyMenuButton
            // 
            this.ToFacultyMenuButton.Location = new System.Drawing.Point(12, 230);
            this.ToFacultyMenuButton.Name = "ToFacultyMenuButton";
            this.ToFacultyMenuButton.Size = new System.Drawing.Size(242, 38);
            this.ToFacultyMenuButton.TabIndex = 51;
            this.ToFacultyMenuButton.Text = "Faculty Menu";
            this.ToFacultyMenuButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 279);
            this.Controls.Add(this.ToFacultyMenuButton);
            this.Controls.Add(this.ToSectionMenuButton);
            this.Controls.Add(this.ToCourseMenuButton);
            this.Controls.Add(this.ToEnrollmentMenuButton);
            this.Controls.Add(this.ToMajorMenuButton);
            this.Controls.Add(this.ToStudentFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ToStudentFormButton;
        private System.Windows.Forms.Button ToMajorMenuButton;
        private System.Windows.Forms.Button ToEnrollmentMenuButton;
        private System.Windows.Forms.Button ToCourseMenuButton;
        private System.Windows.Forms.Button ToSectionMenuButton;
        private System.Windows.Forms.Button ToFacultyMenuButton;
    }
}

