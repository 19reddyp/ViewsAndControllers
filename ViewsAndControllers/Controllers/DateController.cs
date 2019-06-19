using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index()
        {
            DateTime now = DateTime.Now;
            return View(viewName: "Index", model: "Current Date: " + now.ToString());
        }
        [HttpPost]
        public ActionResult changeDate(DateTime date)
        {
            return View(viewName: "Index", model: "Inputted Date: " + date.ToString());
        }
    }
}