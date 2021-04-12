using Hospital_management_system.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.DataAccess_Layer
{
    class PatientemDataAccess
    {
        DataAccess dataAccess;

        public PatientemDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Patient>GetAllPatients()
        {
            string sql = "SELECT * FROM Patientsem";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Patient> Patientsem = new List<Patient>();
            while(reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientId = (int)reader["PatientId"];
                patient.PatientName = reader["PatientName"].ToString();
                patient.PatientAge = (int)reader["PatientAge"];
                patient.PhoneNumber = reader["PhoneNumber"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.Date =reader["Date"].ToString();
                patient.ProblemDescription = reader["ProblemDescription"].ToString();
                patient.DoctorName = reader["DoctorName"].ToString();
                patient.RefferedDoctor = reader["RefferedDoctor"].ToString();
                Patientsem.Add(patient);
            }
            return Patientsem;
        }

        public Patient GetPatient(int id)
        {
            string sql = "SELECT * FROM Patientsem where PatientId="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
           
                Patient patient = new Patient();
                patient.PatientId = (int)reader["PatientId"];
                patient.PatientName = reader["PatientName"].ToString();
                patient.PatientAge = (int)reader["PatientAge"];
                patient.PhoneNumber = reader["PhoneNumber"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.Date = reader["Date"].ToString();
                patient.ProblemDescription = reader["ProblemDescription"].ToString();
                patient.DoctorName = reader["DoctorName"].ToString();
                patient.RefferedDoctor = reader["RefferedDoctor"].ToString();
                return patient;
        }
        public int InsertPatient(Patient patient)
        {
            string sql = "INSERT INTO Patientsem(PatientName,PatientAge,PhoneNumber,Address,Date,ProblemDescription,DoctorName,RefferedDoctor) VALUES('" + patient.PatientName + "'," + patient.PatientAge + ",'" + patient.PhoneNumber + "','" + patient.Address + "','"+patient.Date+"','"+patient.ProblemDescription+"','"+patient.DoctorName+"','"+patient.RefferedDoctor+"')";
            return this.dataAccess.ExecuteQuery(sql);
            //return result;
        }
        public int UpdatePatient(Patient patient)
        {
            string sql = "UPDATE Patientsem SET PatientName='" + patient.PatientName + "'WHERE PatientId=" + patient.PatientId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeletePatient(int id)
        {
            string sql = "DELETE FROM Patientsem WHERE PatientId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public List<string> GetDoctorName()
        {
            string sql = "SELECT * FROM Patientsem";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> Patientsem = new List<string>();
            while (reader.Read())
            {
                Patientsem.Add(reader["DoctorName"].ToString());
            }
            return Patientsem;
        }
        public List<Patient>GetPatientBySearch(string doctorname)
        {
            string sql = "SELECT * FROM Patientsem Where doctorname Like '" + doctorname + "%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Patient> Patientsem = new List<Patient>();
            while(reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientId = (int)reader["PatientId"];
                patient.PatientName = reader["PatientName"].ToString();
                patient.PatientAge = (int)reader["PatientAge"];
                patient.PhoneNumber = reader["PhoneNumber"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.Date = reader["Date"].ToString();
                patient.ProblemDescription = reader["ProblemDescription"].ToString();
                patient.DoctorName = reader["DoctorName"].ToString();
                patient.RefferedDoctor = reader["RefferedDoctor"].ToString();
                Patientsem.Add(patient);

            }
            return Patientsem;
        }
    }
}
