using Microsoft.AspNetCore.Mvc;
using SwagStore.Data;
using SwagStore.Models;
using System.ComponentModel.DataAnnotations;

namespace SwagStore.Controllers
{
    public class RegisterController : Controller
    {
        private readonly StoreDbContext dBContext;

        public RegisterController(StoreDbContext dBContext)
        {
            this.dBContext = dBContext;
        }


        [HttpPost]
        public IActionResult PostRegister(Register register)
        {
            try
            {
                dBContext.Register.Add(register);
                dBContext.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        
        public IActionResult PostRegister()
        {
            return View();
        }

    }
}
