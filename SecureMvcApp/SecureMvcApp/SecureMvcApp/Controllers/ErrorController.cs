using Microsoft.AspNetCore.Mvc;

namespace SecureMvcApp.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult AccessDenied()
        {
            ViewBag.Message = "Access Denied: You do not have permission to view this page.";
            return View();
        }
    }
}
