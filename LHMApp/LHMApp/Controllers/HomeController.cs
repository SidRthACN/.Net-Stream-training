using Microsoft.AspNetCore.Mvc;

namespace LHMApp.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Error() => View();
}
