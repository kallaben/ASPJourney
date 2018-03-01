using Journey.Data;
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
    }
}