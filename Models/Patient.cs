using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3._1.Models
{
    public class Patient
    {
        public Patient() {
            Doctors = new List<Doctor>();

        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MinLength(5), MaxLength(5), Range(0,99999)]
        [Display(Name = "Kod na pacientot")]
        public string PatientCode { get; set; }
        public string Gender { get; set; }
        public List<string> genderOptions = new List<string> { "Male", "Female" };
        public virtual List<Doctor> Doctors { get; set; }
    }
}