using System;
using System.Windows.Forms;
using EmployeeInformation.BLL;
using EmployeeInformation.DAL.DAO;

namespace EmployeeInformation.UI
{
    public partial class DesignationUI : Form
    {
        private Designation aDesignation = new Designation();

        public DesignationUI()
        {
            InitializeComponent();
        }

        public Designation GetLastAddedDesignationByThisUI()
        {
            return aDesignation;
        }

        private void saveDesignationButton_Click(object sender, EventArgs e)
        {
            DesignationManager designationManager = new DesignationManager();
            string message;

            if (codeTextBox.Text != "" &&
            titleTextBox.Text != "")
            {
                aDesignation.Code = codeTextBox.Text;
                aDesignation.Title = titleTextBox.Text;
                try
                {
                    if (designationManager.Save(aDesignation, out message))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Please fill-up the designation fields properly",@"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
