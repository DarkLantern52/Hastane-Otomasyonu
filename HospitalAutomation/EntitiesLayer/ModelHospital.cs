using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HospitalAutomation.EntitiesLayer
{
    public partial class ModelHospital : DbContext
    {
        public ModelHospital()
            : base("name=ModelHospital1")
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Secretary> Secretary { get; set; }
        public virtual DbSet<viewAppointment> viewAppointment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.Opinion)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorSurname)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorTelephone)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorBranch)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientName)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientSurname)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientTelephone)
                .IsUnicode(false);

            modelBuilder.Entity<Secretary>()
                .Property(e => e.SecretaryName)
                .IsUnicode(false);

            modelBuilder.Entity<Secretary>()
                .Property(e => e.SecretarySurname)
                .IsUnicode(false);

            modelBuilder.Entity<viewAppointment>()
                .Property(e => e.PatientName)
                .IsUnicode(false);

            modelBuilder.Entity<viewAppointment>()
                .Property(e => e.Opinion)
                .IsUnicode(false);

            modelBuilder.Entity<viewAppointment>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);

            modelBuilder.Entity<viewAppointment>()
                .Property(e => e.DoctorBranch)
                .IsUnicode(false);
        }
    }
}
