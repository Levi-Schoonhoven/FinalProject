using System.Linq;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private StateContext context {  get; set; }

        public HomeController(StateContext ctx)
        {
            context = ctx;
        }
       

        public IActionResult Index()
        {
            var states = context.States.Include(m=>m.Direction).OrderBy(m=>m.Name).ToList();
            return View(states);
        }

       

       
       
    }
}