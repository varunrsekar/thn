using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace thn.Models
{
    public class forgotPassword
    {
        [Required]
        [Display(Name="Enter your email address:")]
        public string email {get; set;}
    }
}