using Journey.Data;
using Journey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Journey.Controllers
{
    public class JourneyController : Controller
    {
        private HabitData _habitData;

        public JourneyController() {
            _habitData = new HabitData();
        }

        public ActionResult Index()
        {
            return View(_habitData.GetHabits());
        }

        // Habit deletion
        [HttpPost]
        public ActionResult Index(int id)
        {
            _habitData.DeleteHabit(id);
            return RedirectToAction("Index");
        }

        public ActionResult Newhabit()
        {
            var newHabit = new Habit();
            return View();
        }

        [HttpPost]
        public ActionResult Newhabit(Habit newHabit)
        {
            if (ModelState.IsValid)
            {
                _habitData.AddHabit(newHabit);

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}