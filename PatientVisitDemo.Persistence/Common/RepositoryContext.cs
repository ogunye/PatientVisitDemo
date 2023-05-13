using Microsoft.EntityFrameworkCore;
using PatientVisitDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Persistence.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visit_Medication>()
                .HasKey(vm => new { vm.Visit_Id, vm.Medication_Id });

            modelBuilder.Entity<Visit_Procedure>()
                .HasKey(vm => new { vm.Visit_Id, vm.Medical_Procedure_Id });

            // Other entity configurations

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medical_Center> Medical_Centers { get; set; }
        public DbSet<Medical_Procedures> Medical_Procedures { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit_Medication> Visit_Medications { get; set; }
        public DbSet<Visit_Procedure> Visit_Procedures { get; set; }
    }
}
