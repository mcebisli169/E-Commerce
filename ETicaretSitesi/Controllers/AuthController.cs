using ETicaretSitesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretSitesi.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AppUser user)
        {
            return View();
        }
    }
}
