using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _experienceManager.TGetById(id);
            _experienceManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = _experienceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            _experienceManager.TUpdate(experience);

            return RedirectToAction("Index");
        }
        public IActionResult ShowExperience(int id)
        {
            var values = _experienceManager.TGetById(id);
            return View(values);
        }
    }
}
