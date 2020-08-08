using System;
using System.Collections.Generic;
using System.Text;
using Football.Data.Persistence;
using Football.Model.Entities;
using Microsoft.AspNetCore.Identity;

namespace Football.Data.InitialData
{
    public class DataInitializer
    {
        public static void SeedData(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            UnitOfWork unitOfWork)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByEmailAsync("mserna@controlunion.com").Result != null) return;

            var user = new ApplicationUser
            {
                UserName = "",
                Email = "",
                FirstName = "",
                LastName = "",
                Roles = new List<ApplicationUserRole> { new ApplicationUserRole { RoleId = 1 } },
                IsEnabled = true,
                EmailConfirmed = true
            };

            userManager.CreateAsync(user, "2019#2020").Wait();
        }

        public static void SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
        //    roleManager.CreateAsync(new ApplicationRole { Name = "Administrator", NormalizedName = "ADMINISTRATOR", LocalName = "Administrador" }).Wait();
        //    roleManager.CreateAsync(new ApplicationRole { Name = "Manager", NormalizedName = "MANAGER", LocalName = "Manager" }).Wait();
        //    roleManager.CreateAsync(new ApplicationRole { Name = "Eventual", NormalizedName = "EVENTUAL", LocalName = "Eventual" }).Wait();
        }

        private static void CreateRole(RoleManager<ApplicationRole> roleManager, string roleName)
        {
            if (roleManager.RoleExistsAsync(roleName).Result) return;

            var role = new ApplicationRole { Name = roleName };
            var roleResult = roleManager.CreateAsync(role).Result;
        }
    }
}
