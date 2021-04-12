using Hospital_management_system.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.DataAccess_Layer
{
    class ReceptionistDataAccess
    {
        DataAccess dataAccess;
        public ReceptionistDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Receptionist>GetAllReceptionists()
        {
            string sql = "SELECT * FROM Recep";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Receptionist>Recep = new List<Receptionist>();
            while (reader.Read())
            {
                Receptionist receptionist = new Receptionist();
                receptionist.BillId = (int)reader["BillId"];
                receptionist.PatientName = reader["PatientName"].ToString();
                receptionist.TotalAmount = (int)reader["TotalAmount"];
                receptionist.Paid =(int) reader["Paid"];
                receptionist.Due =(int) reader["Due"];
              
                Recep.Add(receptionist);
            }
            return Recep;
        }
        public int InsertReceptionist(Receptionist receptionist)
        {
            string sql = "INSERT INTO Recep(PatientName,TotalAmount,Paid,Due) VALUES('" + receptionist.PatientName + "'," + receptionist.TotalAmount + "," + receptionist.Paid + "," + receptionist.Due + ")";
            return this.dataAccess.ExecuteQuery(sql);
            //return result;
        }
        public int DeleteReceptionist(int billId)
        {
            string sql = "DELETE FROM Recep WHERE BillId=" + billId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
