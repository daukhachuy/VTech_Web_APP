using Microsoft.AspNetCore.Mvc;

namespace PAS_APP.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }

        public IActionResult Logout()
        {
            Console.WriteLine("Logout");
            return View();
        }
    }
}
