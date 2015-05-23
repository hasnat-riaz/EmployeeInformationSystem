namespace EmployeeInformation.UI
{
    partial class EmployeeInformationUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.saveEmployeeButton = new System.Windows.Forms.Button();
            this.addDesignatioButton = new System.Windows.Forms.Button();
            this.designationComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.employeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Designation";
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Controls.Add(this.saveEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.addDesignatioButton);
            this.employeeGroupBox.Controls.Add(this.designationComboBox);
            this.employeeGroupBox.Controls.Add(this.addressTextBox);
            this.employeeGroupBox.Controls.Add(this.emailTextBox);
            this.employeeGroupBox.Controls.Add(this.nameTextBox);
            this.employeeGroupBox.Controls.Add(this.label1);
            this.employeeGroupBox.Controls.Add(this.label4);
            this.employeeGroupBox.Controls.Add(this.label2);
            this.employeeGroupBox.Controls.Add(this.label3);
            this.employeeGroupBox.Location = new System.Drawing.Point(12, 22);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(375, 264);
            this.employeeGroupBox.TabIndex = 1;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Employee Information";
            // 
            // saveEmployeeButton
            // 
            this.saveEmployeeButton.Location = new System.Drawing.Point(271, 224);
            this.saveEmployeeButton.Name = "saveEmployeeButton";
            this.saveEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.saveEmployeeButton.TabIndex = 5;
            this.saveEmployeeButton.Text = "Save";
            this.saveEmployeeButton.UseVisualStyleBackColor = true;
            this.saveEmployeeButton.Click += new System.EventHandler(this.saveEmployeeButton_Click);
            // 
            // addDesignatioButton
            // 
            this.addDesignatioButton.Location = new System.Drawing.Point(271, 167);
            this.addDesignatioButton.Name = "addDesignatioButton";
            this.addDesignatioButton.Size = new System.Drawing.Size(75, 23);
            this.addDesignatioButton.TabIndex = 6;
            this.addDesignatioButton.Text = "Add More...";
            this.addDesignatioButton.UseVisualStyleBackColor = true;
            this.addDesignatioButton.Click += new System.EventHandler(this.addDesignatioButton_Click);
            // 
            // designationComboBox
            // 
            this.designationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationComboBox.FormattingEnabled = true;
            this.designationComboBox.Location = new System.Drawing.Point(95, 167);
            this.designationComboBox.Name = "designationComboBox";
            this.designationComboBox.Size = new System.Drawing.Size(170, 21);
            this.designationComboBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(95, 90);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(251, 67);
            this.addressTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // EmployeeInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 291);
            this.Controls.Add(this.employeeGroupBox);
            this.Name = "EmployeeInformationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.employeeGroupBox.ResumeLayout(false);
            this.employeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveEmployeeButton;
        private System.Windows.Forms.Button addDesignatioButton;
        private System.Windows.Forms.ComboBox designationComboBox;
    }
}

