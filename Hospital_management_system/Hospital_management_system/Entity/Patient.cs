using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Entity
{
    class Patient
    {
        public int PatientId { get; set; }
        public string PatientName{get; set;}
        public int PatientAge { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }
        public string ProblemDescription { get; set; }
        public string DoctorName { get; set; }
        public string RefferedDoctor { get; set; }

    }
}
