using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3._1.Models
{
    public class PatientDoctor
    {
        public PatientDoctor()
        {
            Patients = new List<Patient>();
        }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }
    }
}