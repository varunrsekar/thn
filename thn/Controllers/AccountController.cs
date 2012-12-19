using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thn.Models;

namespace thn.Controllers
{
    public class AccountController : Controller
    {
        static List<user> mm = new List<user>();

        public ActionResult Register()
        {
            return View();
        }

    }
}
