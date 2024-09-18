using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DAL.BogusHandling
{
    public static class UserRoleDataSeed
    {
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            IdentityRole<int> appRole = new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString() //bu ifade sisteminizin yeni bir Guid yaratmasını saglar
            };

            modelBuilder.Entity<IdentityRole<int>>().HasData(appRole);

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            AppUser user = new AppUser()
            {
                Id = 1,
                UserName = "cgr123",
                Email = "cagri@email.com",
                NormalizedEmail = "CAGRI@EMAIL.COM",
                NormalizedUserName = "CGR123",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "cgr123")
            };

            modelBuilder.Entity<AppUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = appRole.Id,
                UserId = user.Id
            });
        }
    }
}
