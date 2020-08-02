using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDownInMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext():base("name = DropDownInMVC")
        {
                
        }

        public DbSet<Country> countries { get; set; }
   
    }
}