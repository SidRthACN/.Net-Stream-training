using LHMApp.Models;
using LHMApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LHMApp.Controllers;

[Authorize]
public class PatientController : Controller
{
    private readonly ILHMService _service;

    public PatientController(ILHMService service) => _service = service;

    [HttpGet]
    public IActionResult Create() => View(new Patient { DateOfBirth = DateTime.Today.AddYears(-18) });

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Patient patient)
    {
        try
        {
            if (patient.DateOfBirth > DateTime.Today)
                ModelState.AddModelError(nameof(patient.DateOfBirth), "Date of Birth cannot be in the future.");

            if (!ModelState.IsValid) return View(patient);

            _service.AddPatient(patient);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {
            ModelState.AddModelError(string.Empty, "Unable to add patient. Please try again.");
            return View(patient);
        }
    }

    public IActionResult Index()
    {
        try
        {
            return View(_service.GetAllPatients());
        }
        catch (Exception)
        {
            TempData["Error"] = "Unable to load patients.";
            return View(new List<Patient>());
        }
    }

    public IActionResult Details(int id)
    {
        try
        {
            var patient = _service.GetPatientById(id);
            if (patient == null) return NotFound();
            return View(patient);
        }
        catch (Exception)
        {
            TempData["Error"] = "Unable to load patient details.";
            return RedirectToAction(nameof(Index));
        }
    }
}
