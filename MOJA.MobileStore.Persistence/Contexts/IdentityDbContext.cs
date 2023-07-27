using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOJA.MobileStore.Domain.Entities.Users;
using MOJA.MobileStore.Domain.Entities.Users.Admins;
using MOJA.MobileStore.Domain.Entities.Users.Customers;
using MOJA.MobileStore.Persistence.Configs.Users;
using MOJA.MobileStore.Persistence.Configs.Users.Customers;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class IdentityDbContext:IdentityDbContext<Person>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
        :base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            _AdminSeeding(builder);

            new CityConfig().Configure(builder.Entity<City>());
            new StateOCConfig().Configure(builder.Entity<StateOC>());
            new CustomerAddressConfig().Configure(builder.Entity<CustomerAddress>());
            new PersonConfig().Configure(builder.Entity<Person>());
        }

        private void _AdminSeeding(ModelBuilder builder)
        {
            var adminId = "b659e8f0-2663-48ac-8c3e-d5ef3726ba92";
            var roleId = "c25eb38a-f9b8-41a3-ab97-70d871fbb225";

            //seedRole
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name="SuperAdmin",
                NormalizedName="SUPERADMIN",
                Id=roleId,
                ConcurrencyStamp=roleId
            });

            //createAdmin
            var admin = new Admin
            {
                Id = adminId,
                UserName = "mjek@gmail.com",
                NormalizedUserName = "MJEK@GMAIL.COM",
                Email = "mjek@gmail.com",
                NormalizedEmail = "MJEK@GMAIL.COM",
                EmailConfirmed = true,
                Name = "محمد جواد",
                Family = "ابراهیمی",
            };

            //setAdminPassword
            var passwordHasher = new PasswordHasher<Admin>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Mjek123@");

            //seedAdmin
            builder.Entity<Admin>().HasData(admin);

            //seedIdentityUserRole
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminId,
                RoleId = roleId,
            });
        }
    }
}
