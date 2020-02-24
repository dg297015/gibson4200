using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gibson4200.Models
{
    public class Doctor
    {
        public int doctorID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required!")]
        [StringLength(150)]

        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(150)]


        public string lastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "You must enter your email address")]

        public string email { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the 3-3-4 digit format")]
        

        public string Phone { get; set; }

       // public ICollection<Appointment> Appointment { get; set; }
    }
}