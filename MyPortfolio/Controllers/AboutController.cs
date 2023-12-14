using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    [Authorize(Roles ="Admin")]
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
            AboutValidator validator = new AboutValidator();
            ValidationResult results = validator.Validate(about);
            if (results.IsValid)
            {
                _aboutManager.TAdd(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
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
            AboutValidator validator = new AboutValidator();
            ValidationResult results = validator.Validate(about);
            if (results.IsValid)
            {
                _aboutManager.TUpdate(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult ShowAbout(int id)
        {
            var values = _aboutManager.TGetById(id);
            return View(values);
        }
    }
}
