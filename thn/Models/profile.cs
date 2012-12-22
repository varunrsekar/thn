using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace thn.Models
{
    public class profile
    {
        [Display(Name = "First Name:")]
        public string firstName { get; set; }

        [Display(Name = "Last Name:")]
        public string lastName { get; set; }

        [Key]
        [Display(Name = "Email:")]
        public string email { get; set; }

        [Display(Name = "Zip code:")]
        public long zipcode { get; set; }

        [Display(Name = "Country:")]
        public string country { get; set; }

        [Display(Name = "About Me:")]
        public string about { get; set; }
        
        [Display(Name = "Search Radius:")]
        public int searchRadius { get; set; }

        public string tags { get; set; }

    }

    public class accountDBContext : DbContext
    {
        public DbSet<profile> profiles { get; set; }
        public DbSet<org> orgs { get; set; }
        public DbSet<user> users { get; set; }
    }
}