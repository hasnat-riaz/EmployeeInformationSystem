using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EmployeeInformation.DAL.DAO;

namespace EmployeeInformation.DAL.Gateway
{
    public class EmployeeGateway : DBGateway
    {
        DesignationGateway designationGateway = new DesignationGateway();

        public string Save(Employee anEmployee)
        {
            string message = "";
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("INSERT INTO tbl_EmployeeInfo VALUES('{0}','{1}','{2}','{3}')", anEmployee.Name,anEmployee.Email,anEmployee.Address,anEmployee.Designation.Id);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
                message = "Employee: " + anEmployee.Name + " has been saved";
            }
            catch(Exception ex)
            {
                throw new Exception("Error occurred during employee save operation. Try again", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }

            return message;
        }

        public string Update(Employee anEmployee)
        {
            string message = "";
            try
            {
                SqlConnectionObj.Open();
                string query =
                    String.Format(
                        "UPDATE tbl_EmployeeInfo SET Name='{0}',Email='{1}',Address='{2}',DesignationId = {3} WHERE Id = {4}",
                        anEmployee.Name, anEmployee.Email, anEmployee.Address, anEmployee.Designation.Id,
                        anEmployee.Id);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
                message = "Information has been updated";
            }
            catch(Exception ex)
            {
                throw new Exception("Error occurred during employee update operation", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return message;
        }

        public string Delete(Employee selectedEmployee)
        {
            string message = "";
                try
                {
                    SqlConnectionObj.Open();
                    string query = String.Format("DELETE FROM tbl_EmployeeInfo WHERE Id={0}", selectedEmployee.Id);
                    SqlCommandObj.CommandText = query;
                    SqlCommandObj.ExecuteNonQuery();
                    message = "Employee: " + selectedEmployee.Name + " has been deleted.";
                }
            catch(Exception exception)
            {
                throw new Exception("Error occurred during employee delete operation " + selectedEmployee.Name, exception);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }

            return message;
        }


        public List<Employee> GetAllEmployee()
        {
            string nameOfName = "";
            return GetAllEmployee(nameOfName);
        }

        public List<Employee> GetAllEmployee(string partOfName)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_EmployeeInfo");

                if (partOfName != "")
                {
                    query += String.Format(" WHERE Name LIKE '%{0}%'", partOfName);
                }

                query += " ORDER BY Name";
                
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    Employee anEmployee = new Employee();
                    anEmployee.Id = Convert.ToInt32(reader["Id"]);
                    anEmployee.Name = reader["Name"].ToString();
                    anEmployee.Email = reader["Email"].ToString();
                    anEmployee.Address = reader["Address"].ToString();
                    anEmployee.Designation = designationGateway.GetDesignation(Convert.ToInt32(reader["DesignationId"]));
                    employees.Add(anEmployee);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error occurred during employee loading from your system.", exception);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return employees;
        }

        public Employee FindEmployee(string email)
        {
            Employee anEmployee = null;
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_EmployeeInfo WHERE Email='{0}'", email);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                
                if (reader != null)
                {
                    while(reader.Read())
                    {
                        anEmployee = new Employee();
                        anEmployee.Id = Convert.ToInt32(reader["Id"]);
                        anEmployee.Name = reader["Name"].ToString();
                        anEmployee.Email = reader["Email"].ToString();
                        anEmployee.Address = reader["Address"].ToString();
                        anEmployee.Designation = designationGateway.GetDesignation(Convert.ToInt32(reader["DesignationId"]));
                        return anEmployee;
                    }
                }
                return null;
            }
            catch (Exception exception)
            {
                throw new Exception("Error occurred during employee loading from your system.", exception);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
        }

        public bool HasEmployeeWithEmail(string email)
        {
            if (FindEmployee(email) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}