using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace thn.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            bool auth = Request.IsAuthenticated;

            if (auth)
            {
                @ViewBag.login = true;
            }
            else
            {
                @ViewBag.login = false;
            }
            return View();
        }

    }
}
