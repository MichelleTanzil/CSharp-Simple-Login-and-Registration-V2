using Microsoft.AspNetCore.Mvc;
using simple_login_registration_version_two.Models;
namespace simple_login_registration_version_two.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        
        [HttpPost("Register")]
        public IActionResult Register(UserViewModel modelData)
        {
            UserRegistration newUser = modelData.NewUser;
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else{
                return View("Index");
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(UserViewModel modelData)
        {
            UserLogin existingUser = modelData.ExistingUser;
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else{
                return View("Index");
            }
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }
}