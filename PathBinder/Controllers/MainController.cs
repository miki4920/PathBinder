using Microsoft.AspNetCore.Mvc;
using PathBinder.Models;
using System.Diagnostics;

namespace PathBinder.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Write()
        {
            return View();
        }

        public IActionResult Library()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}