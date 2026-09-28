using LHMApp.Models;
using LHMApp.Repositories;

namespace LHMApp.Services;

public class LHMService : ILHMService
{
    private readonly ILHMRepo _repo;

    public LHMService(ILHMRepo repo) => _repo = repo;

    public bool AddPatient(Patient patient) => _repo.AddPatient(patient);
    public Patient? GetPatientById(int id) => _repo.GetPatientById(id);
    public List<Patient> GetAllPatients() => _repo.GetAllPatients();
    public bool AddAppointment(Appointment appointment) => _repo.AddAppointment(appointment);
    public List<Appointment> GetAllAppointments() => _repo.GetAllAppointments();
}
