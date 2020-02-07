using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gibson4200.Models;
using System.Data.Entity;

namespace gibson4200.DAL
{
    public class MedicalContext : DbContext
    {
        public MedicalContext() : base("name=DefaultConnection")
        {
            

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}