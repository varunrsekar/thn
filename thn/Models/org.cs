using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace thn.Models
{
    public class org
    {

        [Key]
        [Required(ErrorMessage = "Organization name is required.")]
        [Display(Name = "Organization Name:")]
        public string orgName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email:")]
        public string email { get; set; }
        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "Country:")]
        public string country { get; set; }
        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code:")]
        public long zipcode { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }


    public class vieworg
    {

        [Key]
        [Required(ErrorMessage = "Organization name is required.")]
        [Display(Name = "Organization Name:")]
        public string orgName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email:")]
        public string email { get; set; }
        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "Country:")]
        public string country { get; set; }
        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code:")]
        public long zipcode { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Re enter your password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm password:")]
        public string comparePassword { get; set; }

    }
    public class orgDBContext : DbContext
    {
        public DbSet<org> orgs { get; set; }
    }
}