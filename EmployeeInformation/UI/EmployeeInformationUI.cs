using System;
using System.Windows.Forms;
using EmployeeInformation.BLL;
using EmployeeInformation.DAL.DAO;

namespace EmployeeInformation.UI
{
    public partial class EmployeeInformationUI : Form
    {
        DesignationManager designationManager = new DesignationManager();
        private EmployeeManager employeeManager = new EmployeeManager();

        private int employeeId;

        public EmployeeInformationUI()
        {
            InitializeComponent();
            LoadAllDesignation();
        }

        public EmployeeInformationUI(Employee employee) : this()
        {
            saveEmployeeButton.Text = @"Update";
            FillFieldsWith(employee);
            employeeId = employee.Id;
        }
        
        private void FillFieldsWith(Employee employee)
        {
            nameTextBox.Text = employee.Name;
            addressTextBox.Text = employee.Address;
            emailTextBox.Text = employee.Email;
            designationComboBox.SelectedValue = employee.Designation.Id;
        }

        public void  LoadAllDesignation()
        {
            try
            {
                designationComboBox.DataSource = designationManager.GetAll();
                designationComboBox.DisplayMember = "Title";
                designationComboBox.ValueMember = "Id";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Id = employeeId;
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;

            anEmployee.Designation = (Designation) designationComboBox.SelectedItem;
            if (nameTextBox.Text != "" &&
                    emailTextBox.Text != "" &&
                    addressTextBox.Text != "" &&
                    designationComboBox.Text != "")
            {
                if (saveEmployeeButton.Text != @"Update")
                {
                    string message = "";
                    try
                    {
                        message = employeeManager.Save(anEmployee);
                        MessageBox.Show(message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ClearEmployee();
                }
                else
                {
                    try
                    {
                        string message = employeeManager.Update(anEmployee);
                        MessageBox.Show(message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearEmployee();                           
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(@"Please fill-up the employee's information properly", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addDesignatioButton_Click(object sender, EventArgs e)
        {
            DesignationUI designationUi = new DesignationUI();
            designationUi.ShowDialog();
            LoadAllDesignation();
            Designation lastAddedDesignation = designationUi.GetLastAddedDesignationByThisUI();
            if (lastAddedDesignation != null)
            {
                designationComboBox.Text = lastAddedDesignation.Title;
            }
        }

        private void ClearEmployee()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            designationComboBox.Text = "";
        }
    }
}
