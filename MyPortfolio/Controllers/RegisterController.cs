using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RegisterController : Controller
    {
        private readonly UserManager<User> _userManager;
        public RegisterController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            User u = new User()
            {
                Name = "Test",
                Surname =   "Test",
                Email = "admin1@gmail.com",
                UserName = "yusufkggoglu1"
            };
            
            var result = await _userManager.CreateAsync(u, "123456Yy*");
            return View();
        }
    }
}
