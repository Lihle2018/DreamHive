using DreamHive.Models;
using Microsoft.AspNetCore.Mvc;

namespace DreamHive.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(Contact contact)
        {
            if(ModelState.IsValid )
            {
                return View();
            }
            return View(contact);
        }
    }
}
