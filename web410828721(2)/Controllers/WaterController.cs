using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410828721_2_.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(String name, float? weight)
        {
            var result = "";
            if (weight.HasValue) 
            {
                //根據體重*30算完之後將數值加上單位cc的字串
                result = (weight * 30) + "cc";

                if (weight.HasValue)
                {
                    result = (weight * 30) + "cc";
                }

            }

            ViewBag.name = name;
            ViewBag.result = result;

            return View();
        }
    }
}