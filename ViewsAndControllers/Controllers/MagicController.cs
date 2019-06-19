using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class MagicController : Controller
    {
        // GET: Magic
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0.0);
        }

        [HttpPost]
        public ActionResult SayMagic(int one, int two)
        {
            Random gen = new Random();
            int random = gen.Next(one,two);
            return View(viewName: "Index", model: random);
        }
    }
}