using Hospital_management_system.DataAccess_Layer;
using Hospital_management_system.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Business_Logic_Layer
{
    class PatientEmservice
    {
        PatientemDataAccess patientemDataAccess;
        public PatientEmservice()
        {
           this.patientemDataAccess = new PatientemDataAccess();//this.
        }
        public List<Patient> GetListOfPatients()
        {
            return this. patientemDataAccess.GetAllPatients();
        }
        public int AddNewPatient(string patientName, string patientAge, string phoneNumber, string address, string date, string problemdescription, string doctorName, string refferedDoctor)

        {
            Patient patient = new Patient()

            {
                PatientName = patientName,
                PatientAge = Convert.ToInt32(patientAge),
                PhoneNumber = phoneNumber,
                Address = address,
                Date= date,
                ProblemDescription=problemdescription,
                DoctorName=doctorName,
                RefferedDoctor=refferedDoctor,
            };
            patientemDataAccess = new PatientemDataAccess();
            return patientemDataAccess.InsertPatient(patient);


        }
        public int DeletePatient(string patientId)
        {
            return this.patientemDataAccess.DeletePatient(Convert.ToInt32(patientId));
        }
        public List<string>GetDoctorNameList()
        {
            return this.patientemDataAccess.GetDoctorName();
        }
        public List<Patient>GetPatientListBySearch(string doctorName)
        {
            return patientemDataAccess.GetPatientBySearch(doctorName);
        }
            
    }

}