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
        [Display(Name = "About Me:")]
        public string about { get; set; }
        
        [Display(Name = "Search Radius:")]
        public string searchRadius { get; set; }

        public IList<string> tags { get; set; }

        [Key]
        public string email { get; set; }
    }

    public class profileDBContext : DbContext
    {
        public DbSet<profile> profiles { get; set; }
    }
}