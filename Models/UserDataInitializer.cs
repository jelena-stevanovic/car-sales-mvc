using Microsoft.AspNetCore.Identity;

namespace CarsSelling.Models
{
    public static class UserDataInitializer
    {
        public static void InsertUserData(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@gmail.com"
                };
                var result = userManager.CreateAsync(user, "Admin_123456789").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        public static void InsertRoleData(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}

