using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
