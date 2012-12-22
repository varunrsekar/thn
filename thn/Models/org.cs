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
        [Required(ErrorMessage = "Organization name is required.")]
        [Display(Name = "Organization Name:")]
        [DataType(DataType.Text)]
        public string orgName { get; set; }

        [Key]
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address:")]
        [DataType(DataType.MultilineText)]
        public string address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City:")]
        [DataType(DataType.Text)]
        public string address { get; set; }

        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code:")]
        [DataType(DataType.PostalCode)]
        public long zipcode { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "Country:")]
        public string country { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [Display(Name = "Organisation Description:")]
        [DataType(DataType.MultilineText)]
        public string description { get; set; }


        public double lat { get; set; }
        public double lng { get; set; }

    }


    public class vieworg
    {
        [Required(ErrorMessage = "Organization name is required.")]
        [Display(Name = "Organization Name:")]
        [DataType(DataType.Text)]
        public string orgName { get; set; }

        [Key]
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address:")]
        [DataType(DataType.MultilineText)]
        public string address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City:")]
        [DataType(DataType.Text)]
        public string address { get; set; }

        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code:")]
        [DataType(DataType.PostalCode)]
        public long zipcode { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "Country:")]
        public string country { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [Display(Name = "Organisation Description:")]
        [DataType(DataType.MultilineText)]
        public string description { get; set; }
        

        [Required(ErrorMessage = "Re enter your password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm password:")]
        public string comparePassword { get; set; }

    }
}