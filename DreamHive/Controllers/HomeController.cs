using DreamHive.Models;
using DreamHive.Services;
using Microsoft.AspNetCore.Mvc;


namespace DreamHive.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailService _emailService;
        public HomeController(EmailService emailService)
        {
                _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if(ModelState.IsValid )
            {
                _emailService.SendEmail(contact.Email, "2018293130@ufs4life.ac.za", contact.Subject, contact.Message);
                return View();
            }
            return View(contact);
        }
    }
}
