using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gibson4200.Models
{
    public class AppointmentDetail
    {
        public int appointmentDetailID { get; set; }
        [Display(Name ="Prescription")]
        [StringLength(3)]
        public int prescriptionQuantityOrdered { get; set; }
        [Display(Name ="Cost")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int appointmentID { get; set; }
        public virtual Appointment Appointment { get; set; }
        // the next two properties link the orderDetail to the Product
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }

    }
}