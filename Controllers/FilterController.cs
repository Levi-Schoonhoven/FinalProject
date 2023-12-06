using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class FilterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private StateContext context { get; set; }
        public FilterController(StateContext ctx)
        {
            context = ctx;
        }


        public IActionResult List(String id = "All")
        {
            ViewBag.Direction = context.Directions.ToList();
            ViewBag.SelectedDirection = id;
            List<Direction> directions = context.Directions.Where(d => d.Name == id).ToList();
            return View(directions);

        }
    }
}
