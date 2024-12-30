using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Worldcup.Models;

namespace Worldcup.Controllers
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
            var Category = new List<Categories>
            {
                new Categories
                {
                    Id = 1,
                    Name = "الملاعب",
                    Icon=" <i class=\"fa fa-futbol text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                    Url="Stadiums"

                },

                 new Categories
                {
                    Id = 2,
                    Name = "جدول المباريات",
                     Icon=" <i class=\"fa fa-clock text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>"
                },

                   new Categories
                {
                    Id = 3,
                    Name = "الفنادق",
                    Icon=" <i class=\"fa fa-bed text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>"
                },
            };
            return View(Category);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("stadiums")]
       
        public async Task<IActionResult> Stadiums()
        {
            var stadume = new List<Stadiums>
            {
                new Stadiums
                {
                    Id = 1,
                    Name = "ملعب الملك فهد الدولي",
                    Capacity = 68752,
                    City = "الرياض",
                    Type = "كرة قدم",
                    ConstructionDate = new DateTime(1987, 6, 18),
                    Owner = "الهيئة العامة للرياضة",
                    Length = 105,
                    Width = 68,
                    Facilities = new List<string> { "مواقف سيارات", "مطاعم", "شاشات عملاقة" },
                    Image="images/f.PNG"
                },

                 new Stadiums
                {
                    Id = 2,
                    Name = "ملعب مدينة الملك عبدالله الرياضية",
                    Capacity = 65000,
                    City = "جدة",
                    Type = "كرة قدم",
                    ConstructionDate = new DateTime(1987, 6, 18),
                    Owner = "الهيئة العامة للرياضة",
                    Length = 105,
                    Width = 68,
                    Facilities = new List<string> { "مواقف سيارات", "مطاعم", "شاشات عملاقة" },
                    Image="images/a.PNG"
                }
            };
            return View(stadume);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
