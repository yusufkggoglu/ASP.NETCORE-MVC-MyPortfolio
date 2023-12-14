using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = _serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCertificate(Service service)
        {
            _serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCertificate(int id)
        {
            var value = _serviceManager.TGetById(id);
            _serviceManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCertificate(int id)
        {
            var values = _serviceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditCertificate(Service service)
        {
            _serviceManager.TUpdate(service);

            return RedirectToAction("Index");
        }
        public IActionResult ShowCertificate(int id)
        {
            var values = _serviceManager.TGetById(id);
            return View(values);
        }
    }
}
