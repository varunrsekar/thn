using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thn.Models;

namespace thn.Controllers
{
    public class editProfileController : Controller
    {
        private profileDBContext dbprof = new profileDBContext();

        //
        // GET: /EditProfile/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(profile prof)
        {
            prof.email = User.Identity.Name;
            profile profileExists = dbprof.profiles.Where(b => b.email == prof.email).FirstOrDefault();

            if (profileExists != null)
            {
                dbprof.profiles.Add(prof);
                dbprof.SaveChanges();
                return RedirectToAction("Index", "dashboard");
            }
            else
                ModelState.AddModelError("", "There is no user with this email address.");
            return View();
        }

    }
}
