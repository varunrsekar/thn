﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thn.Models;

namespace thn.Controllers
{
    public class cpanelController : Controller
    {
        private orgDBContext db = new orgDBContext();

        public ActionResult Index()
        {
            bool auth = Request.IsAuthenticated;

            if (auth)
            {
                @ViewBag.login = true;
                return View();
            }

            return RedirectToAction("", "login");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}