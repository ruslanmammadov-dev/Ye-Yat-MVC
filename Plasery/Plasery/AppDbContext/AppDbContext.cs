using Microsoft.EntityFrameworkCore;
using Plasery.Models;

namespace Plasery.AppDb
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<DoctorService> DoctorServices { get; set; }
        public DbSet<DoctorsSocialLink> SocialLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorService>()
                .HasKey(ds => new { ds.DoctorId, ds.ServiceId });

            base.OnModelCreating(modelBuilder);
        }

    }

}
