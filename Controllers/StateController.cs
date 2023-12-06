using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class StateController : Controller
    {
        private StateContext context {  get; set; }
        public StateController(StateContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Directions = context.Directions.OrderBy(x => x.Name).ToList();
            return View("Edit",new State());
        }
        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            ViewBag.Directions = context.Directions.OrderBy(x=>x.Name).ToList();
            var state = context.States.Find(id);
            return View(state);
        }
        [HttpGet]
        public IActionResult filter(int id)
        {
            ViewBag.Action = "filter";
            ViewBag.Directions = context.Directions.OrderBy(x => x.Name).ToList();
            var state = context.States.Find(id);
            return View(state);
        }
        [HttpPost]
        public IActionResult Edit(State state)
        {
            if (ModelState.IsValid)
            {
                if (state.StateId == 0)

                    context.States.Add(state);
                else
                    context.States.Update(state);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (state.StateId == 0) ? "Add" : "Edit";
                ViewBag.Directions = context.Directions.OrderBy(x => x.Name).ToList();
                return View(state);
            }


        } 
            [HttpGet]
            public IActionResult Delete(int id)
            {
                var state = context.States.Find(id);
                return View(state);
            }
            [HttpPost]
            public IActionResult Delete(State state)
            {
                context.States.Remove(state);
                context.SaveChanges();
                return RedirectToAction("Index","Home");
            }

        public IActionResult List(String id = "All")
        {
            ViewBag.Direction = context.Directions.ToList();
            ViewBag.SelectedDirection = id;
            List<Direction> directions = context.Directions.Where(d =>d.Name == id).ToList();
            return View(directions);

        }

    }
}
