namespace CollegeRegistration
{
    partial class FacultyForm
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
            this.FacultyGrid = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveFacultyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.FacultyNameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FacultyGrid
            // 
            this.FacultyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacultyGrid.Location = new System.Drawing.Point(13, 13);
            this.FacultyGrid.Name = "FacultyGrid";
            this.FacultyGrid.RowTemplate.Height = 31;
            this.FacultyGrid.Size = new System.Drawing.Size(739, 336);
            this.FacultyGrid.TabIndex = 0;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(226, 464);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(209, 42);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(437, 464);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(209, 42);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveFacultyButton
            // 
            this.SaveFacultyButton.Location = new System.Drawing.Point(13, 464);
            this.SaveFacultyButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveFacultyButton.Name = "SaveFacultyButton";
            this.SaveFacultyButton.Size = new System.Drawing.Size(211, 42);
            this.SaveFacultyButton.TabIndex = 20;
            this.SaveFacultyButton.Text = "Save";
            this.SaveFacultyButton.UseVisualStyleBackColor = true;
            this.SaveFacultyButton.Click += new System.EventHandler(this.SaveFacultyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter Faculty Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter Phone Number";
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Location = new System.Drawing.Point(213, 416);
            this.PhoneNumberInput.Margin = new System.Windows.Forms.Padding(6);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(433, 29);
            this.PhoneNumberInput.TabIndex = 24;
            // 
            // FacultyNameInput
            // 
            this.FacultyNameInput.Location = new System.Drawing.Point(213, 372);
            this.FacultyNameInput.Margin = new System.Windows.Forms.Padding(6);
            this.FacultyNameInput.Name = "FacultyNameInput";
            this.FacultyNameInput.Size = new System.Drawing.Size(433, 29);
            this.FacultyNameInput.TabIndex = 23;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 782);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.FacultyNameInput);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveFacultyButton);
            this.Controls.Add(this.FacultyGrid);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            ((System.ComponentModel.ISupportInitialize)(this.FacultyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FacultyGrid;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveFacultyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNumberInput;
        private System.Windows.Forms.TextBox FacultyNameInput;
    }
}