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
            this.components = new System.ComponentModel.Container();
            this.CourseGrid = new System.Windows.Forms.DataGridView();
            this.DepartmentSearch = new System.Windows.Forms.TextBox();
            this.FindDeptButton = new System.Windows.Forms.Button();
            this.registrationDataSet = new CollegeRegistration.RegistrationDataSet();
            this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet = new CollegeRegistration.CourseDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new CollegeRegistration.CourseDataSetTableAdapters.CourseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseNameInput = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CreditsInput = new System.Windows.Forms.TextBox();
            this.CourseNumberInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DepartmentInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseGrid
            // 
            this.CourseGrid.AutoGenerateColumns = false;
            this.CourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.CourseGrid.DataSource = this.courseBindingSource;
            this.CourseGrid.Location = new System.Drawing.Point(12, 12);
            this.CourseGrid.Name = "CourseGrid";
            this.CourseGrid.RowTemplate.Height = 31;
            this.CourseGrid.Size = new System.Drawing.Size(995, 238);
            this.CourseGrid.TabIndex = 0;
            // 
            // DepartmentSearch
            // 
            this.DepartmentSearch.Location = new System.Drawing.Point(12, 269);
            this.DepartmentSearch.Name = "DepartmentSearch";
            this.DepartmentSearch.Size = new System.Drawing.Size(297, 29);
            this.DepartmentSearch.TabIndex = 1;
            // 
            // FindDeptButton
            // 
            this.FindDeptButton.Location = new System.Drawing.Point(341, 264);
            this.FindDeptButton.Name = "FindDeptButton";
            this.FindDeptButton.Size = new System.Drawing.Size(178, 40);
            this.FindDeptButton.TabIndex = 2;
            this.FindDeptButton.Text = "Find Department";
            this.FindDeptButton.UseVisualStyleBackColor = true;
            this.FindDeptButton.Click += new System.EventHandler(this.FindDeptButton_Click);
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
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "CourseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.courseDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1025, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Enter Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1023, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enter Amount of Credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1025, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter Course Number";
            // 
            // CourseNameInput
            // 
            this.CourseNameInput.Location = new System.Drawing.Point(1291, 12);
            this.CourseNameInput.Name = "CourseNameInput";
            this.CourseNameInput.Size = new System.Drawing.Size(298, 29);
            this.CourseNameInput.TabIndex = 20;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1403, 194);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 56);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1222, 194);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(176, 56);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreditsInput
            // 
            this.CreditsInput.Location = new System.Drawing.Point(1291, 100);
            this.CreditsInput.MaxLength = 2;
            this.CreditsInput.Name = "CreditsInput";
            this.CreditsInput.Size = new System.Drawing.Size(298, 29);
            this.CreditsInput.TabIndex = 17;
            // 
            // CourseNumberInput
            // 
            this.CourseNumberInput.Location = new System.Drawing.Point(1291, 56);
            this.CourseNumberInput.Name = "CourseNumberInput";
            this.CourseNumberInput.Size = new System.Drawing.Size(298, 29);
            this.CourseNumberInput.TabIndex = 16;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1028, 194);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(188, 56);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1023, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Enter Department";
            // 
            // DepartmentInput
            // 
            this.DepartmentInput.Location = new System.Drawing.Point(1291, 146);
            this.DepartmentInput.MaxLength = 4;
            this.DepartmentInput.Name = "DepartmentInput";
            this.DepartmentInput.Size = new System.Drawing.Size(298, 29);
            this.DepartmentInput.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(994, 248);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1604, 704);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseNameInput);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreditsInput);
            this.Controls.Add(this.CourseNumberInput);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FindDeptButton);
            this.Controls.Add(this.DepartmentSearch);
            this.Controls.Add(this.CourseGrid);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CourseGrid;
        private System.Windows.Forms.TextBox DepartmentSearch;
        private System.Windows.Forms.Button FindDeptButton;
        private System.Windows.Forms.BindingSource registrationDataSetBindingSource;
        private RegistrationDataSet registrationDataSet;
        private CourseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CourseDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourseNameInput;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox CreditsInput;
        private System.Windows.Forms.TextBox CourseNumberInput;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DepartmentInput;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}