using Microsoft.AspNetCore.Mvc;

namespace SwagStore.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Register");
        }

        public IActionResult PostRegister()
        {
            return View();
        }
    }
}
