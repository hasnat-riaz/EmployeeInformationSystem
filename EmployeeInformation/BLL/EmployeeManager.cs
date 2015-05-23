using System;
using System.Collections.Generic;
using EmployeeInformation.DAL.DAO;
using EmployeeInformation.DAL.Gateway;

namespace EmployeeInformation.BLL
{
    public class EmployeeManager
    {
        private EmployeeGateway employeeGateway = new EmployeeGateway();

        public string Save(Employee anEmployee)
        {
            if (employeeGateway.HasEmployeeWithEmail(anEmployee.Email))
            {
                throw new Exception("Your system already has an employee with this email address. Try again");
            }
            else
            {
                return employeeGateway.Save(anEmployee);    
            }
        }

        public List<Employee> GetAllEmployees(string nameWord)
        {
            return employeeGateway.GetAllEmployee(nameWord);
        }

        public string Update(Employee anEmployee)
        {
            Employee selectedEmployee = employeeGateway.FindEmployee(anEmployee.Email);
            if (selectedEmployee.Id != anEmployee.Id)
            {
                return "Your system already has an employee with this email address. Try again";
            }
            else
            {
                return employeeGateway.Update(anEmployee);
            }
        }

        public string DeleteEmployee(Employee selectedEmployee)
        {
            return employeeGateway.Delete(selectedEmployee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeGateway.GetAllEmployee();
            
        }
    }
}