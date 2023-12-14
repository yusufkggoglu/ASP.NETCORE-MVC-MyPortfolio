using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = _aboutManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutManager.TAdd(about);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutManager.TGetById(id);
            _aboutManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = _aboutManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            _aboutManager.TUpdate(about);

            return RedirectToAction("Index");
        }
        public IActionResult ShowAbout(int id)
        {
            var values = _aboutManager.TGetById(id);
            return View(values);
        }
    }
}
