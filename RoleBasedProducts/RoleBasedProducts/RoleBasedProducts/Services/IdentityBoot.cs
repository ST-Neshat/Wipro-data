using Microsoft.AspNetCore.Identity;

namespace SecureMvcApp.Helpers
{
    public static class IdentityBoot
    {
        public static async Task EnsureRolesAsync(IServiceProvider services)
        {
            var rolesNeeded = new[] { "Admin", "Manager" };
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            foreach (var role in rolesNeeded)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
