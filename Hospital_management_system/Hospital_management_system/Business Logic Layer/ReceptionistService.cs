using Hospital_management_system.DataAccess_Layer;
using Hospital_management_system.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Business_Logic_Layer
{
    class ReceptionistService
    {
        ReceptionistDataAccess receptionistDataAccess;
        public ReceptionistService()
        {
            receptionistDataAccess = new ReceptionistDataAccess();
        }
        public List<Receptionist>GetReceptionistList()
        {
            return receptionistDataAccess.GetAllReceptionists();
        }
          public int AddNewReceptionist(string patientName, string totalAmount, string paid, string due)

        {
            Receptionist receptionist = new Receptionist()

            {
                PatientName = patientName,
                TotalAmount = Convert.ToInt32(totalAmount),
                Paid = Convert.ToInt32(paid),
                Due = Convert.ToInt32(due),
             
            };
            receptionistDataAccess = new ReceptionistDataAccess();
            return receptionistDataAccess.InsertReceptionist(receptionist);


        }
        public int UpdateReceptionist(string patientName, string totalAmount, string paid, string due)

        {
            Receptionist receptionist = new Receptionist()

            {
                //BillId = Convert.ToInt32(billId),
                PatientName = patientName,
                TotalAmount = Convert.ToInt32(totalAmount),
                Paid = Convert.ToInt32(paid),
                Due = Convert.ToInt32(due),

            };
            receptionistDataAccess = new ReceptionistDataAccess();
            return receptionistDataAccess.InsertReceptionist(receptionist);


        }
        public int DeleteReceptionist(string billId)
        {
            return this.receptionistDataAccess.DeleteReceptionist(Convert.ToInt32(billId));
        }
    }
}
