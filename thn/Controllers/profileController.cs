using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thn.Models;

namespace thn.Controllers
{
    public class profileController : Controller
    {
        private profileDBContext dbprof = new profileDBContext();

        //
        // GET: /EditProfile/

        public ActionResult editProfile()
        {
            bool auth = Request.IsAuthenticated;

            if (auth)
            {
                @ViewBag.login = true;
                return View();
            }

            return RedirectToAction("", "login");
        }

        [HttpPost]
        public ActionResult editProfile(profile prof)
        {
            prof.email = User.Identity.Name;
            if (ModelState.IsValid)
            {

                profile profileExists = dbprof.profiles.Where(b => b.email == prof.email).FirstOrDefault();
                    
                if (profileExists != null)
                {
                    profileExists.about = prof.about;
                    profileExists.country = prof.country;
                    profileExists.firstName = prof.firstName;
                    profileExists.lastName = prof.lastName;
                    profileExists.searchRadius = prof.searchRadius;
                    profileExists.tags = prof.tags;
                    profileExists.zipcode = prof.zipcode;

                    dbprof.SaveChanges();
                    return RedirectToAction("Index", "dashboard");
                }
                else
                    ModelState.AddModelError("", "There is no user with this email address.");
            }
            return View();
        }

    }
}
