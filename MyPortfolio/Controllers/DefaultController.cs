using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
