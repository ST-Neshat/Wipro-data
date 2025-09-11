using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SecureLoginApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SecureLoginApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Dashboard()
        {
            var users = _userManager.Users.ToList();
            var userDetails = new System.Collections.Generic.List<object>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userDetails.Add(new
                {
                    user.UserName,
                    user.Email,
                    user.FirstName,
                    user.LastName,
                    Roles = string.Join(", ", roles)
                });
            }

            ViewBag.Message = "Welcome, Admin! You have access to the Admin Dashboard.";
            ViewBag.Users = userDetails;

            return View();
        }
    }
}