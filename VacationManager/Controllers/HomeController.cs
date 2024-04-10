using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VacationManager.Models;

namespace VacationManager.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }       
    }
}