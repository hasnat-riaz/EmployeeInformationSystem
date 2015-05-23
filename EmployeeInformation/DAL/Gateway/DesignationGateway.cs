using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EmployeeInformation.DAL.DAO;

namespace EmployeeInformation.DAL.Gateway
{
    public class DesignationGateway :DBGateway
    {
        public List<Designation> GetAll()
        {
            List<Designation> designations = new List<Designation>();
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_Designation");
                SqlCommandObj.CommandText = query;
                SqlDataReader readerObj = SqlCommandObj.ExecuteReader();
                while (readerObj.Read())
                {
                    Designation aDesignation = new Designation();
                    aDesignation.Id = Convert.ToInt32(readerObj["Id"]);
                    aDesignation.Code = readerObj["Code"].ToString();
                    aDesignation.Title = readerObj["Title"].ToString();
                    designations.Add(aDesignation);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Designation couldn't loaded from your system", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return designations;
        }
        public Designation GetDesignation(int designationId)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_Designation WHERE Id='{0}'", designationId);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                Designation aDesignation = new Designation();
                while (reader.Read())
                {
                    aDesignation.Id = Convert.ToInt32(reader["Id"]);
                    aDesignation.Code = reader["Code"].ToString();
                    aDesignation.Title = reader["Title"].ToString();
                }
                
                return aDesignation;
            }
            catch (Exception ex)
            {
                throw new Exception("Designation couldn't loaded from your system", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
        }

        public bool Save(Designation aDesignation)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("INSERT INTO tbl_Designation VALUES('{0}','{1}')", aDesignation.Code,
                                             aDesignation.Title);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               throw new Exception("Designation couldn't saved",ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
            return true;
        }

        public bool HasThisDesignationCode(string code)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_Designation WHERE Code='{0}'", code);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader != null)
                {
                    return reader.HasRows;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Designation couldn't loaded from your system", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
        }

        public bool HasThisDesignationTitle(string title)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = String.Format("SELECT * FROM tbl_Designation WHERE Title='{0}'", title);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader != null)
                {
                    return reader.Read();
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Designation couldn't loaded from your system", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }            
        }
    }
}