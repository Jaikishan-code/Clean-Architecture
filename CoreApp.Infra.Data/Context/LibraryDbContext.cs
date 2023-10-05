using CoreApp.Domain.Models;
using CoreApp.Domain.Models.Identity;
using CoreApp.Domain.Models.Masters;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Infra.Data.Context
{
    public class LibraryDbContext : IdentityDbContext<ApplicationUser>
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookCategory> BookCategories { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<User>().ToTable("Users", "Identity");
            //builder.Entity<IdentityRole<Guid>>().ToTable("Roles", "Identity");
            //builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims", "Identity");
            //builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims", "Identity");
            //builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles", "Identity");
            //builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens", "Identity");
            //builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin", "Identity");

            builder.Entity<ApplicationUser>().ToTable("Users", "Identity");
            builder.Entity<Seasons>().ToTable("Seasons", "Master");
            //builder.Entity<IdentityRole>().ToTable("Roles", "Identity");
            //builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims", "Identity");
            //builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims", "Identity");
            //builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles", "Identity");
            //builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens", "Identity");
            //builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin", "Identity");

        }

    }
}
