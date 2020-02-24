using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace gibson4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }

        [Display(Name ="Description")]
        [Required (ErrorMessage ="Description is required!")]
        [StringLength(150)]

        public string description { get; set; }

        [Display(Name = "Appointment Date")]
        [Required(ErrorMessage = "Appointment Date is required!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy", ApplyFormatInEditMode = true)]

        public DateTime appDate { get; set; }
        
       
        
        //public int doctorID { get; set; }
        //public virtual Doctor Doctor { get; set; }

    }
}