namespace CollegeRegistration
{
    partial class StudentForm
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
            this.StudentStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMajorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindStudentButton = new System.Windows.Forms.Button();
            this.SaveStudentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentStudentID,
            this.StudentName,
            this.StudentMajorID});
            this.dataGridView1.Location = new System.Drawing.Point(475, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(436, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentStudentID
            // 
            this.StudentStudentID.HeaderText = "StudentID";
            this.StudentStudentID.Name = "StudentStudentID";
            this.StudentStudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            // 
            // StudentMajorID
            // 
            this.StudentMajorID.HeaderText = "Major";
            this.StudentMajorID.Name = "StudentMajorID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(475, 476);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Enter Student ID";
            // 
            // FindStudentButton
            // 
            this.FindStudentButton.Location = new System.Drawing.Point(475, 527);
            this.FindStudentButton.Name = "FindStudentButton";
            this.FindStudentButton.Size = new System.Drawing.Size(158, 42);
            this.FindStudentButton.TabIndex = 2;
            this.FindStudentButton.Text = "Search";
            this.FindStudentButton.UseVisualStyleBackColor = true;
            // 
            // SaveStudentButton
            // 
            this.SaveStudentButton.Location = new System.Drawing.Point(942, 207);
            this.SaveStudentButton.Name = "SaveStudentButton";
            this.SaveStudentButton.Size = new System.Drawing.Size(142, 38);
            this.SaveStudentButton.TabIndex = 3;
            this.SaveStudentButton.Text = "Save";
            this.SaveStudentButton.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 713);
            this.Controls.Add(this.SaveStudentButton);
            this.Controls.Add(this.FindStudentButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMajorID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindStudentButton;
        private System.Windows.Forms.Button SaveStudentButton;
    }
}