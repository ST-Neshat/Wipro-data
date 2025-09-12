using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace SecureMvcApp.Infrastructure
{
    public static class IdentitySeeder
    {
        public static async Task SeedAsync(IServiceScope scope)
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // Ensure roles
            var roles = new[] { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // Ensure default admin
            const string adminUserName = "admin";
            const string adminPassword = "Admin@123";

            var admin = await userManager.FindByNameAsync(adminUserName);
            if (admin == null)
            {
                admin = new IdentityUser { UserName = adminUserName };
                var createResult = await userManager.CreateAsync(admin, adminPassword);
                if (createResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
            }
        }
    }
}
