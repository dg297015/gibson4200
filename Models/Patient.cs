using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gibson4200.Models
{
    public class Patient
    {
        public int patientID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }
    }
}