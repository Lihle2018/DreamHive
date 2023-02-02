using DreamHive.Models;
using DreamHive.Services;
using Microsoft.AspNetCore.Mvc;


namespace DreamHive.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailService _emailService;
        private readonly FirebaseRealTimeServices _firebase;
        public HomeController(EmailService emailService, FirebaseRealTimeServices firebase)
        {
            _emailService = emailService;
            _firebase= firebase;    
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Contact contact)
        {
            if(ModelState.IsValid )
            {
               await _emailService.SendEmail(contact.Email, "2018293130@ufs4life.ac.za", contact.Subject, contact.Message);
                await _firebase.SaveMessage(contact);
                return PartialView("_ContactFormPartial");
            }
            else
            {
                return PartialView("_ContactFormPartial",contact);
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> Subscribe(Subscription subscription)
        {
            if(ModelState.IsValid)
            {
                var message = "Thank you for subscribing to our newsletter! We're excited to share our updates and content with you, and we hope you find it valuable and informative. If you have any feedback or suggestions for future newsletters, please don't hesitate to reach out to us. We appreciate your support and look forward to staying connected with you.";
                var Subject= "Thanks for signing up for our updates!";
                var from = "mqhayilihle@gmail.com";
                var newSub = new Subscription()
                {
                    Id = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    Email = subscription.Email
                };
              await  _emailService.SendEmail(from, subscription.Email, Subject, message);
                await _firebase.AddSubscription(newSub);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index",subscription);
            }
            
        }
    }
}
