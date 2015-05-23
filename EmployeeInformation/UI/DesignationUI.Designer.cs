namespace EmployeeInformation.UI
{
    partial class DesignationUI
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
            this.designationGroupBox = new System.Windows.Forms.GroupBox();
            this.saveDesignationButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.designationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // designationGroupBox
            // 
            this.designationGroupBox.Controls.Add(this.saveDesignationButton);
            this.designationGroupBox.Controls.Add(this.titleTextBox);
            this.designationGroupBox.Controls.Add(this.codeTextBox);
            this.designationGroupBox.Controls.Add(this.label6);
            this.designationGroupBox.Controls.Add(this.label5);
            this.designationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.designationGroupBox.Name = "designationGroupBox";
            this.designationGroupBox.Size = new System.Drawing.Size(266, 154);
            this.designationGroupBox.TabIndex = 3;
            this.designationGroupBox.TabStop = false;
            this.designationGroupBox.Text = "Designation";
            // 
            // saveDesignationButton
            // 
            this.saveDesignationButton.Location = new System.Drawing.Point(185, 100);
            this.saveDesignationButton.Name = "saveDesignationButton";
            this.saveDesignationButton.Size = new System.Drawing.Size(75, 23);
            this.saveDesignationButton.TabIndex = 9;
            this.saveDesignationButton.Text = "Save";
            this.saveDesignationButton.UseVisualStyleBackColor = true;
            this.saveDesignationButton.Click += new System.EventHandler(this.saveDesignationButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.AcceptsReturn = true;
            this.titleTextBox.Location = new System.Drawing.Point(73, 61);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(187, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(73, 27);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(119, 20);
            this.codeTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code";
            // 
            // DesignationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 177);
            this.Controls.Add(this.designationGroupBox);
            this.Name = "DesignationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Designation";
            this.designationGroupBox.ResumeLayout(false);
            this.designationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox designationGroupBox;
        private System.Windows.Forms.Button saveDesignationButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}