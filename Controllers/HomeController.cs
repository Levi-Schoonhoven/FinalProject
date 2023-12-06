using System.Linq;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

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

        /*
       public ViewResult Index(string activeDirec = "all")
                                
        {
            ViewBag.ActiveDirec = activeDirec;
            
            List<Direction> directions = context.Directions.ToList();
            //List<Filter> filters = context.Filter.ToList();

            directions.Insert(0, new Direction
            {
                DirectionId = "all",
                Name = "All"
            });
            ViewBag.Directions = directions;
            IQueryable<Direction> query = context.Directions;
            if (activeDirec != "all")
                query = query.Where(
                    d => d.DirectionId.ToLower() == activeDirec.ToLower());
            var direct = query.ToList();
            return View(direct);
        }*/



    }
}