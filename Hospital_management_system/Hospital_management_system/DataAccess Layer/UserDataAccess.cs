using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.DataAccess_Layer
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public bool LoginValidation(string username,string password)
        {
            string sql = "SELECT * FROM Usersd WHERE UserName='"+username+"'AND Password'"+password+"'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if(reader.Read())
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
