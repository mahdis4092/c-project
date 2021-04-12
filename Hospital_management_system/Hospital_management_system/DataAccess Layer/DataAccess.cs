using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.DataAccess_Layer
{
    class DataAccess:IDisposable
    {
        SqlConnection connection;
        SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FA"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            SqlDataReader reader = this.command.ExecuteReader();
          //  this.connection.Close();
            return reader;
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            int result = this.command.ExecuteNonQuery();
            this.connection.Close();
            return result;
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}