using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class ApplicationDbContext: DbContext//IdentityDbContext<ApplicationUser>
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}