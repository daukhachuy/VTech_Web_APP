using Microsoft.AspNetCore.Mvc;

namespace PAS_APP.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }
    }
}
