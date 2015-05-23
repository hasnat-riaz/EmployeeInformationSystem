using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeInformation.DAL.Gateway
{
    public class DBGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public DBGateway()
        {
            connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString);
            commandObj = new SqlCommand();
        }

        public SqlConnection SqlConnectionObj
        {
            get
            {
                return connectionObj;
            }
        }

        public SqlCommand SqlCommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
    }
}
