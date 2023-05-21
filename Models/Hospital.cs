using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3._1.Models
{
    public class Hospital
    {
        public Hospital() { 
        Doctors= new List<Doctor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageURL { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }  

    }
}