using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thn.Models;

namespace thn.Controllers
{
    public class dashboardController : Controller
    {
        private accountDBContext db = new accountDBContext();

        //
        // GET: /dashboard/

        public ActionResult Index()
        {
            bool auth = Request.IsAuthenticated;

            string email = User.Identity.Name;
            user userExists = db.users.Where(b => b.email == email).FirstOrDefault();

            if (userExists == null)
                auth = false;

            if (auth)
            {
                @ViewBag.login = true;
                return View();
            }

            return RedirectToAction("","login");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}