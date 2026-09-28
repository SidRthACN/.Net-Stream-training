using LHMApp.Models;

namespace LHMApp.Services;

public interface ILHMService
{
    bool AddPatient(Patient patient);
    Patient? GetPatientById(int id);
    List<Patient> GetAllPatients();
    bool AddAppointment(Appointment appointment);
    List<Appointment> GetAllAppointments();
}
