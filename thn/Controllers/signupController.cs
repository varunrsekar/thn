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
        private userDBContext dbuser = new userDBContext();
        private orgDBContext dborg = new orgDBContext();

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
            return RedirectToAction("individual");
        }
        
        public ActionResult individual()
        {
            @ViewBag.login = false;
            return View();
        }

        [HttpPost]
        public ActionResult individual(user input)
        {
            if (ModelState.IsValid)
            {
                @ViewBag.login = false;
                    org orgExists = dborg.orgs.Where(a => a.email == input.email).FirstOrDefault(); 
                    user userExists = dbuser.users.Where(b => b.email == input.email).FirstOrDefault();
                    if ((userExists == null)&&(orgExists == null))
                    {
                        input.password = encryptPassword(input.password);
                        dbuser.users.Add(input);
                        dbuser.SaveChanges();
                        return RedirectToAction("Index", "login");
                    }
                    else if (userExists != null)
                    {
                        ModelState.AddModelError("","An individual user already exists for the email address.");
                    }
                    else
                        ModelState.AddModelError("", "An organization already has an account using this email address.");
            }

            return View();
        }

        
        
        public ActionResult ngo()
        {
            @ViewBag.login = false;
            
            return View();
        }

        [HttpPost]
        public ActionResult ngo(org input)
        {
            if (ModelState.IsValid)
            {
                org orgExists = dborg.orgs.Where(a => a.email == input.email).FirstOrDefault();
                user userExists = dbuser.users.Where(b => b.email == input.email).FirstOrDefault();
                if ((userExists == null) && (orgExists == null))
                {
                    input.password = encryptPassword(input.password);
                    dborg.orgs.Add(input);
                    dborg.SaveChanges();
                    return RedirectToAction("Index", "login");
                }
                else if (userExists != null)
                {
                    ModelState.AddModelError("", "An individual user already exists for the email address.");
                }
                else
                    ModelState.AddModelError("", "An organization already has an account using this email address.");
            }

            return View();
        }

        
        
        protected override void Dispose(bool disposing)
        {
            dbuser.Dispose();
            base.Dispose(disposing);

            dborg.Dispose();
            base.Dispose(disposing);
        }
    }
}