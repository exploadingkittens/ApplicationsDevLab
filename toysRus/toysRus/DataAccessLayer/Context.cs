using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using toysRus.Models;
using System.Data.Entity;

namespace toysRus.DataAccessLayer
{
    public class Context : IdentityDbContext<User>
    {
        public DbSet<ToyCategory> Categories { get; set; }
        public DbSet<Toy> Toys { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        }
    }
}