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
        private accountDBContext dbuser = new accountDBContext();
        private accountDBContext dborg = new accountDBContext();
        //
        // GET: /login/

        private static string encryptPassword(string password)
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
            @ViewBag.login = false;
            return View();
        }

        [HttpPost]
        public ActionResult Index(user user)
        {
            user userExists = dbuser.users.Where(b => b.email == user.email).FirstOrDefault();
            org orgExists = dborg.orgs.Where(a => a.email == user.email).FirstOrDefault();

            user.password = encryptPassword(user.password);

            if (orgExists != null)
            {

                if ((orgExists.password == user.password) && (orgExists.email == user.email))
                {
                    FormsAuthentication.SetAuthCookie(user.email, false);
                    return RedirectToAction("Index", "cpanel");
                }
                else
                    ModelState.AddModelError("", "Username or password does not exist.");
            }
            else if (userExists != null)
            {

                if ((userExists.password == user.password) && (userExists.email == user.email))
                {
                    FormsAuthentication.SetAuthCookie(user.email, true);
                    return RedirectToAction("Index", "dashboard");
                }
                else
                    ModelState.AddModelError("", "Username or password does not exist.");
            }
            return View();
        }

    }
}
