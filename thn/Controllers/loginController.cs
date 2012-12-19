using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using thn.Models;
using System.Web.Security;

namespace thn.Controllers
{
    public class loginController : Controller
    {
        private userDBContext db = new userDBContext();
        //
        // GET: /login/

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
        public ActionResult Index(user user)
        {
            user temp = db.users.Where(b => b.email == user.email).FirstOrDefault();

            user.password = encryptPassword(user.password);

            if ((temp.password == user.password) && (temp.email == user.email))
            {
                FormsAuthentication.SetAuthCookie(user.email, false);
                return RedirectToAction("Index", "dashboard");
            }
            else
                ModelState.AddModelError("","Username or password does not exist.");
            return View();
        }

    }
}
