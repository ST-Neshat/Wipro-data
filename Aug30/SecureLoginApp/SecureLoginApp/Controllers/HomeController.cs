using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SecureLoginApp.Models;
using SecureLoginApp.Data;
using System.Threading.Tasks;

namespace SecureLoginApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> UserProfile()
        {
            var user = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(user);

            var profile = new UserProfile
            {
                Username = user.UserName,
                Email = user.Email,
                Role = roles.FirstOrDefault()
            };

            ViewBag.Message = "Welcome, User! Here is your profile information.";
            return View(profile);
        }
    }
}