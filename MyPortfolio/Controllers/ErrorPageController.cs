using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
