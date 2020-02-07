using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gibson4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public string description { get; set; }
        public DateTime appDate { get; set; }
        
       
        
        //public int doctorID { get; set; }
        //public virtual Doctor Doctor { get; set; }

    }
}