using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeInformation.BLL;
using EmployeeInformation.DAL.DAO;

namespace EmployeeInformation.UI
{
    public partial class FindEmployeeUI : Form
    {
        private EmployeeManager employeeManager = new EmployeeManager();

        public FindEmployeeUI()
        {
            InitializeComponent();
        }

        private string partialName = "";

        private void searchButton_Click(object sender, EventArgs e)
        {
            partialName = searchTextBox.Text;
            LoadListView(partialName);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = GetSelectedEmployee();
            if (selectedEmployee != null)
            {
                EmployeeInformationUI employeeInformationUi = new EmployeeInformationUI(selectedEmployee);
                employeeInformationUi.ShowDialog();
                LoadListView(partialName);
                resultListView.HideSelection = false;
            }
        }

        private Employee GetSelectedEmployee()
        {
            int index = resultListView.SelectedIndices[0];
            ListViewItem item = resultListView.Items[index];
            return (Employee) item.Tag;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            editToolStripMenuItem.Enabled = (resultListView.Items.Count > 0);
            deleteToolStripMenuItem.Enabled = (resultListView.Items.Count > 0);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = GetSelectedEmployee();
            int selectedIndex = resultListView.SelectedIndices[0];
            DialogResult result =
                MessageBox.Show("You are about to delete " + selectedEmployee.Name + " \nIs that alright?",
                                "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    employeeManager.DeleteEmployee(selectedEmployee);
                    resultListView.Items.RemoveAt(selectedIndex);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        public void LoadListView(string partialName)
        {
            resultListView.Items.Clear();
            List<Employee> employees;
            try
            {
                employees = employeeManager.GetAllEmployees(partialName);
                if (employees.Count > 0)
                {
                    int serialNo = 1;
                    foreach (Employee employee in employees)
                    {
                        ListViewItem anItem = new ListViewItem(serialNo.ToString());
                        anItem.Tag = (Employee) employee;
                        anItem.SubItems.Add(employee.Name);
                        anItem.SubItems.Add(employee.Email);
                        resultListView.Items.Add(anItem);
                        serialNo++;
                    }
                }
                else
                {
                    MessageBox.Show(@"Employee with given searching criteria is not found in your system", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
