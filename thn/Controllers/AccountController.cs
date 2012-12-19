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
    public class AccountController : Controller
    {
        private userDBContext db = new userDBContext();

        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        public static string encryptPassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(user user)
        {
            if (ModelState.IsValid)
            {
                user.password = encryptPassword(user.password);
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}