using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3._1.Models
{
    public class Doctor
    {
        public Doctor() {
            Patients = new List<Patient>();
            Hospitals = new List<Hospital>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public List<Hospital> Hospitals { get; set; }
    }
}