using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410828721_2_.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult HW2()
        {
            return View();
        }

        public ActionResult HW3()
        {
            ViewBag.poka = "Hello";
            return View();
        }
    }
}