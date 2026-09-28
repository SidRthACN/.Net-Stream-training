using LHMApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LHMApp.Data;

public class LHMDbContext : DbContext
{
    public LHMDbContext(DbContextOptions<LHMDbContext> options) : base(options) { }

    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<Appointment> Appointments { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // The connection string is normally supplied by Program.cs from appsettings.json.
        // Keeping this override satisfies the DAL requirement while avoiding hard-coded credentials.
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LHM;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(p => p.PatientId);
            entity.Property(p => p.PatientName).HasMaxLength(35).IsRequired();
            entity.Property(p => p.ContactNo).HasMaxLength(35).IsRequired();
            entity.Property(p => p.DateOfBirth).IsRequired();
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(a => a.AppointmentId);
            entity.Property(a => a.AppointmentDate).IsRequired();
            entity.HasOne(a => a.Patient)
                  .WithMany(p => p.Appointments)
                  .HasForeignKey(a => a.PatientId)
                  .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
