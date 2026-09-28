using LHMApp.Models;
using LHMApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LHMApp.Controllers;

[Authorize]
public class AppointmentController : Controller
{
    private readonly ILHMService _service;

    public AppointmentController(ILHMService service) => _service = service;

    [HttpGet]
    public IActionResult Create()
    {
        try
        {
            LoadPatients();
            return View(new Appointment { AppointmentDate = DateTime.Now.AddHours(1) });
        }
        catch (Exception)
        {
            TempData["Error"] = "Unable to load appointment form.";
            return RedirectToAction(nameof(Index));
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Appointment appointment)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                LoadPatients();
                return View(appointment);
            }

            if (_service.GetPatientById(appointment.PatientId) == null)
            {
                ModelState.AddModelError(nameof(appointment.PatientId), "Selected patient does not exist.");
                LoadPatients();
                return View(appointment);
            }

            _service.AddAppointment(appointment);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Unable to add appointment. Please try again.");
            LoadPatients();
            return View(appointment);
        }
    }

    public IActionResult Index()
    {
        try
        {
            return View(_service.GetAllAppointments());
        }
        catch (Exception)
        {
            TempData["Error"] = "Unable to load appointments.";
            return View(new List<Appointment>());
        }
    }

    private void LoadPatients()
    {
        ViewBag.Patients = new SelectList(_service.GetAllPatients(), "PatientId", "PatientName");
    }
}
