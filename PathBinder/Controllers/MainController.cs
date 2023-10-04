using Microsoft.AspNetCore.Mvc;
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
    }
}