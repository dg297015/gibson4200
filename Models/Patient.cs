using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gibson4200.Models
{
    public class Patient
    {
        public int patientID { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(150)]

        public string name { get; set; }
        [Display(Name = "Mobil Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the 3-3-4 digit format")]


        public string phone { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "You must enter your email address")]


        public string email { get; set; }




        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }
    }
}