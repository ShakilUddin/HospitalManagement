using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Data
{
    class HospitalDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SNRF64I;Database=EFHGospitalDB;Trusted_Connection=True;");
        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Lab> Labs { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Inpatient> Inpatients { get; set; }

        public DbSet<Outpatient> Outpatients { get; set; }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<DoctorDepartment> DoctorDepartments { get; set; }
    }
}
