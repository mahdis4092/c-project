using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Entity
{
    class Receptionist
    {

        public int BillId { get; set; }
        public string PatientName { get; set; }
        public int TotalAmount { get; set; }
        public int Paid { get; set; }
        public int Due{ get; set; }
    }
}
