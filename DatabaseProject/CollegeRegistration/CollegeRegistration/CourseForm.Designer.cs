namespace CollegeRegistration
{
    partial class CourseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindDeptButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCourseID,
            this.CourseCourseName,
            this.CourseDepartment});
            this.dataGridView1.Location = new System.Drawing.Point(284, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(548, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseCourseID
            // 
            this.CourseCourseID.HeaderText = "Course ID";
            this.CourseCourseID.Name = "CourseCourseID";
            this.CourseCourseID.ReadOnly = true;
            // 
            // CourseCourseName
            // 
            this.CourseCourseName.HeaderText = "Course Name";
            this.CourseCourseName.Name = "CourseCourseName";
            // 
            // CourseDepartment
            // 
            this.CourseDepartment.HeaderText = "Department";
            this.CourseDepartment.Name = "CourseDepartment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 413);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 29);
            this.textBox1.TabIndex = 1;
            // 
            // FindDeptButton
            // 
            this.FindDeptButton.Location = new System.Drawing.Point(284, 468);
            this.FindDeptButton.Name = "FindDeptButton";
            this.FindDeptButton.Size = new System.Drawing.Size(178, 40);
            this.FindDeptButton.TabIndex = 2;
            this.FindDeptButton.Text = "Find Department";
            this.FindDeptButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(863, 152);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 42);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 704);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FindDeptButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDepartment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindDeptButton;
        private System.Windows.Forms.Button SaveButton;
    }
}