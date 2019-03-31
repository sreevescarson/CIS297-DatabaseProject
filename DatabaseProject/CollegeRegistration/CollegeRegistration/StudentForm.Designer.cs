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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationDataSet = new CollegeRegistration.RegistrationDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new CollegeRegistration.StudentDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilterStudentButton = new System.Windows.Forms.Button();
            this.SaveStudentButton = new System.Windows.Forms.Button();
            this.studentTableAdapter = new CollegeRegistration.RegistrationDataSetTableAdapters.StudentTableAdapter();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.majorTableAdapter = new CollegeRegistration.RegistrationDataSetTableAdapters.MajorTableAdapter();
            this.registrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new CollegeRegistration.StudentDataSetTableAdapters.StudentsTableAdapter();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.MajorIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilteredDataGrid = new System.Windows.Forms.DataGridView();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.FilterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.majorIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(631, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // majorIDDataGridViewTextBoxColumn
            // 
            this.majorIDDataGridViewTextBoxColumn.DataPropertyName = "MajorID";
            this.majorIDDataGridViewTextBoxColumn.HeaderText = "MajorID";
            this.majorIDDataGridViewTextBoxColumn.Name = "majorIDDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.registrationDataSet;
            this.studentBindingSource.CurrentChanged += new System.EventHandler(this.studentBindingSource_CurrentChanged);
            // 
            // registrationDataSet
            // 
            this.registrationDataSet.DataSetName = "RegistrationDataSet";
            this.registrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 360);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Enter Major Name";
            // 
            // FilterStudentButton
            // 
            this.FilterStudentButton.Location = new System.Drawing.Point(493, 360);
            this.FilterStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.FilterStudentButton.Name = "FilterStudentButton";
            this.FilterStudentButton.Size = new System.Drawing.Size(158, 37);
            this.FilterStudentButton.TabIndex = 2;
            this.FilterStudentButton.Text = "Search";
            this.FilterStudentButton.UseVisualStyleBackColor = true;
            this.FilterStudentButton.Click += new System.EventHandler(this.FindStudentButton_Click);
            // 
            // SaveStudentButton
            // 
            this.SaveStudentButton.Location = new System.Drawing.Point(834, 153);
            this.SaveStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveStudentButton.Name = "SaveStudentButton";
            this.SaveStudentButton.Size = new System.Drawing.Size(141, 39);
            this.SaveStudentButton.TabIndex = 3;
            this.SaveStudentButton.Text = "Save";
            this.SaveStudentButton.UseVisualStyleBackColor = true;
            this.SaveStudentButton.Click += new System.EventHandler(this.SaveStudentButton_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.registrationDataSet;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "Major";
            this.majorBindingSource.DataSource = this.registrationDataSet;
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // registrationDataSetBindingSource
            // 
            this.registrationDataSetBindingSource.DataSource = this.registrationDataSet;
            this.registrationDataSetBindingSource.Position = 0;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.registrationDataSetBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(834, 20);
            this.NameInput.Margin = new System.Windows.Forms.Padding(6);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(374, 29);
            this.NameInput.TabIndex = 4;
            // 
            // MajorIDInput
            // 
            this.MajorIDInput.Location = new System.Drawing.Point(834, 90);
            this.MajorIDInput.Margin = new System.Windows.Forms.Padding(6);
            this.MajorIDInput.Name = "MajorIDInput";
            this.MajorIDInput.Size = new System.Drawing.Size(374, 29);
            this.MajorIDInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Major ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Name";
            // 
            // FilteredDataGrid
            // 
            this.FilteredDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilteredDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilterName});
            this.FilteredDataGrid.Location = new System.Drawing.Point(20, 404);
            this.FilteredDataGrid.Name = "FilteredDataGrid";
            this.FilteredDataGrid.RowTemplate.Height = 31;
            this.FilteredDataGrid.Size = new System.Drawing.Size(145, 219);
            this.FilteredDataGrid.TabIndex = 8;
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(829, 304);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(64, 25);
            this.StudentLabel.TabIndex = 9;
            this.StudentLabel.Text = "label3";
            // 
            // FilterName
            // 
            this.FilterName.HeaderText = "Name";
            this.FilterName.Name = "FilterName";
            this.FilterName.ReadOnly = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.FilteredDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MajorIDInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.SaveStudentButton);
            this.Controls.Add(this.FilterStudentButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
           
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FilterStudentButton;
        private System.Windows.Forms.Button SaveStudentButton;
        private RegistrationDataSet registrationDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private RegistrationDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private RegistrationDataSetTableAdapters.MajorTableAdapter majorTableAdapter;
        private System.Windows.Forms.BindingSource registrationDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox MajorIDInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView FilteredDataGrid;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilterName;
    }
}