using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelCreation.Models;

namespace ModelCreation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var companions = new List<CompanionsDetailsClass>
            {
                new CompanionsDetailsClass { Name = "Abu Bakr Siddiq", DateOfBirth = "573 AD", DateOfDeath = "634 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Umar ibn al-Khattab", DateOfBirth = "584 AD", DateOfDeath = "644 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Uthman ibn Affan", DateOfBirth = "576 AD", DateOfDeath = "656 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Ali ibn Abi Talib", DateOfBirth = "599 AD", DateOfDeath = "661 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Talha ibn Ubaydullah", DateOfBirth = "594 AD", DateOfDeath = "656 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Zubayr ibn al-Awwam", DateOfBirth = "573 AD", DateOfDeath = "656 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Sa'd ibn Abi Waqqas", DateOfBirth = "595 AD", DateOfDeath = "674 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Abdur Rahman ibn Awf", DateOfBirth = "581 AD", DateOfDeath = "652 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Abu Ubaidah ibn al-Jarrah", DateOfBirth = "583 AD", DateOfDeath = "639 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Sa'id ibn Zayd", DateOfBirth = "593 AD", DateOfDeath = "671 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Abu Hurairah", DateOfBirth = "603 AD", DateOfDeath = "678 AD", PlaceOfBirth = "Yemen" },
                new CompanionsDetailsClass { Name = "Bilal ibn Rabah", DateOfBirth = "Approximately 580 AD", DateOfDeath = "640 AD", PlaceOfBirth = "Abyssinia" },
                new CompanionsDetailsClass { Name = "Khalid ibn al-Walid", DateOfBirth = "592 AD", DateOfDeath = "642 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Ammar ibn Yasir", DateOfBirth = "570 AD", DateOfDeath = "657 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Salman al-Farsi", DateOfBirth = "Approximately 568 AD", DateOfDeath = "656 AD", PlaceOfBirth = "Persia" },
                new CompanionsDetailsClass { Name = "Abu Dharr al-Ghifari", DateOfBirth = "601 AD", DateOfDeath = "652 AD", PlaceOfBirth = "Arabia" },
                new CompanionsDetailsClass { Name = "Mus'ab ibn Umair", DateOfBirth = "594 AD", DateOfDeath = "624 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Ja'far ibn Abi Talib", DateOfBirth = "590 AD", DateOfDeath = "629 AD", PlaceOfBirth = "Makkah" },
                new CompanionsDetailsClass { Name = "Abdullah ibn Mas'ud", DateOfBirth = "594 AD", DateOfDeath = "653 AD", PlaceOfBirth = "Makkah" }
            };

            ViewData["myCompanions"] = companions;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}