using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace thn.Models
{
    public class user
    {

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name="First Name:")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name:")]
        public string lastName { get; set; }
        [Key]
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email:")]
        public string email { get; set; }
        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code:")]
        public long zipcode { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }

    
    public class viewuser
    {

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name:")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name:")]
        public string lastName { get; set; }
        [Key]
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email:")]
        public string email { get; set; }
        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code:")]
        public long zipcode { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Re enter your password")]
        [DataType(DataType.Password)]
        [Compare("password")]
        [Display(Name = "Confirm password:")]
        public string comparePassword { get; set; }

    }
    public class userDBContext : DbContext
    {
        public DbSet<user> users { get; set; }
    }
}