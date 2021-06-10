using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web410828721_2_.ViewModels;

namespace web410828721_2_.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }

        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        {
            
            if (ModelState.IsValid)
            {
                ViewBag.Message = "註冊成功";
            }
                return View(data);
        }
    }
}