using LHMApp.Data;
using LHMApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LHMApp.Repositories;

public class LHMRepo : ILHMRepo
{
    private readonly LHMDbContext _context;

    public LHMRepo(LHMDbContext context) => _context = context;

    public bool AddPatient(Patient patient)
    {
        _context.Patients.Add(patient);
        return _context.SaveChanges() > 0;
    }

    public Patient? GetPatientById(int id) =>
        _context.Patients.Include(p => p.Appointments).FirstOrDefault(p => p.PatientId == id);

    public List<Patient> GetAllPatients() =>
        _context.Patients.AsNoTracking().OrderBy(p => p.PatientId).ToList();

    public bool AddAppointment(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        return _context.SaveChanges() > 0;
    }

    public List<Appointment> GetAllAppointments() =>
        _context.Appointments.AsNoTracking()
            .Include(a => a.Patient)
            .OrderBy(a => a.AppointmentDate)
            .ToList();
}
