using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EducationController : Controller
    {
        EducationManager _educationManager = new EducationManager(new EfEducationDal());
        public IActionResult Index()
        {
            var values = _educationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            _educationManager.TAdd(education);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var value = _educationManager.TGetById(id);
            _educationManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            var values = _educationManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditEducation(Education education)
        {
            _educationManager.TUpdate(education);

            return RedirectToAction("Index");
        }
        public IActionResult ShowEducation(int id)
        {
            var values = _educationManager.TGetById(id);
            return View(values);
        }
    }
}
