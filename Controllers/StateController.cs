using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
