using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
<<<<<<< HEAD
using VictuzBeta.Models;
=======
using Victuz.Models;
>>>>>>> 40034713999ffddfb830ed1ef18feeae66801caf
using Activity = System.Diagnostics.Activity;

namespace Victuz.Controllers
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
