using System;
using System.Windows.Forms;

namespace EmployeeInformation.UI
{
    public partial class MainMenuUI : Form
    {
        public MainMenuUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EmployeeInformationUI employeeInformationUi = new EmployeeInformationUI();
            employeeInformationUi.Show();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            FindEmployeeUI findEmployeeUi =  new FindEmployeeUI();
            findEmployeeUi.Show();
        }
    }
}
