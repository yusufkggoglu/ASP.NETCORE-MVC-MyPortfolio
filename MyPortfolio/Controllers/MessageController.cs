using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        MessageManager _messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = _messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteShowMessage(int id)
        {
            var value = _messageManager.TGetById(id);
            _messageManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult ShowMessage(int id)
        {
            var values = _messageManager.TGetById(id);
            return View(values);
        }
    }
}
