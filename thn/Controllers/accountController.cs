using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thn.Models;
using System.Net.Mail;

namespace thn.Controllers
{
    public class accountController : Controller
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

        public ActionResult forgotPassword()
        {
            @ViewBag.login = false;
            return View();
        }

        [HttpPost]
        public ActionResult forgotPassword(forgotPassword input)
        {
            org orgExists = dborg.orgs.Where(a => a.email == input.email).FirstOrDefault();
            user userExists = dbuser.users.Where(b => b.email == input.email).FirstOrDefault();

            if (orgExists != null)
            {
                var newPassword = encryptPassword(orgExists.password);
                var dbPassword = encryptPassword(newPassword);

                orgExists.password = dbPassword;
                dborg.SaveChanges();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Credentials = new System.Net.NetworkCredential("admin@thehalonetwork.org", "godspeed123");
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;

                mail.From = new MailAddress("admin@thehalonetwork.org");
                mail.To.Add("maniganz@gmail.com");
                mail.Subject = "New password from The Halo Network";
                mail.Body = "Hi, your new password is " + newPassword;

                SmtpServer.Send(mail);
            }
            else if (userExists != null)
            {
                var newPassword = encryptPassword(userExists.password);
                var dbPassword = encryptPassword(newPassword);

                userExists.password = dbPassword;
                dbuser.SaveChanges();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Credentials = new System.Net.NetworkCredential("admin@thehalonetwork.org", "godspeed123");
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;

                mail.From = new MailAddress("admin@thehalonetwork.org");
                mail.To.Add(userExists.email);
                mail.Subject = "New password from The Halo Network";
                mail.Body = "Hi, your new password is " + newPassword;

                SmtpServer.Send(mail);
            }
            else
                ModelState.AddModelError("","Email does not exist.");
            @ViewBag.login = false;
            return View();
        }

    }
}
