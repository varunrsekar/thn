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
    public class signupController : Controller
    {
        private userDBContext db = new userDBContext();

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

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user input)
        {
            if (ModelState.IsValid)
            {
                    input.password = encryptPassword(input.password);
                    db.users.Add(input);
                    db.SaveChanges();
                    return RedirectToAction("/");
            }

            return View(input);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}