using Chartify.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Chartify.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            var password = "thecheaterBG20";
            var passwordHasher = new PasswordHasher<User>();

            var adminRole = new Role()
            {
                Name = "Admin"
            };
            adminRole.NormalizedName = adminRole.Name.ToUpper();

            var userRole = new Role()
            {
                Name = "User"
            };
            userRole.NormalizedName = userRole.Name.ToUpper();

            var featuredArtistRole = new Role()
            {
                Name = "Featured Artist"
            };
            featuredArtistRole.NormalizedName = featuredArtistRole.Name.ToUpper();

            var mapperRole = new Role()
            {
                Name = "Mapper"
            };
            mapperRole.NormalizedName = mapperRole.Name.ToUpper();

            List<Role> roles = new List<Role>()
            {   adminRole,
                userRole,
                featuredArtistRole,
                mapperRole
            };

            builder.Entity<Role>().HasData(roles);

            //adding an admin user
            var adminUser = new User();

            adminUser.UserName = "shad0w";
            adminUser.Email = "a@admin.com";
            adminUser.CreationDate = DateTime.Now;
            adminUser.LastLoginDate = DateTime.Now;
            adminUser.EmailConfirmed = true;

            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, password);

            //adding a normal user
            var regularUser = new User();

            regularUser.UserName = "onegai";
            regularUser.Email = "u@user.com";
            regularUser.CreationDate = DateTime.Now;
            regularUser.LastLoginDate = DateTime.Now;
            regularUser.EmailConfirmed = true;

            regularUser.NormalizedUserName = regularUser.UserName.ToUpper();
            regularUser.NormalizedEmail = regularUser.Email.ToUpper();
            regularUser.PasswordHash = passwordHasher.HashPassword(regularUser, password);

            //adding a featured artist user
            var faUser = new User();

            faUser.UserName = "namirin";
            faUser.Email = "fa@arist.com";
            faUser.CreationDate = DateTime.Now;
            faUser.LastLoginDate = DateTime.Now;
            faUser.EmailConfirmed = true;

            faUser.NormalizedUserName = faUser.UserName.ToUpper();
            faUser.NormalizedEmail = faUser.Email.ToUpper();
            faUser.PasswordHash = passwordHasher.HashPassword(faUser, password);

            //adding a mapper user user
            var mapperUser = new User();

            mapperUser.UserName = "Sotarks";
            mapperUser.Email = "m@mapper.com";
            mapperUser.CreationDate = DateTime.Now;
            mapperUser.LastLoginDate = DateTime.Now;
            mapperUser.EmailConfirmed = true;

            mapperUser.NormalizedUserName = mapperUser.UserName.ToUpper();
            mapperUser.NormalizedEmail = mapperUser.Email.ToUpper();
            mapperUser.PasswordHash = passwordHasher.HashPassword(mapperUser, password);

            List<User> users = new List<User>()
            {
                adminUser,
                regularUser,
                faUser,
                mapperUser
            };

            builder.Entity<User>().HasData(users);

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            for (int i = 0; i <= 3; i++)
            {
                userRoles.Add(new IdentityUserRole<string>()
                {
                    UserId = users[i].Id,
                    RoleId = roles[i].Id
                });
            }

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
