using CalculatorAll.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculatorAll.Controllers
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

        public IActionResult Calculator01()
        {
            return View();
        }

        public IActionResult Calculator02()
        {
            return View();
        }

        public IActionResult Calculator03()
        {
            return View();
        }

        public IActionResult Calculator04()
        {
            return View();
        }

        public IActionResult Calculator05()
        {
            return View();
        }

        public IActionResult Calculator06()
        {
            return View();
        }

        public IActionResult Calculator07()
        {
            return View();
        }

        public IActionResult Calculator08()
        {
            return View();
        }

        public IActionResult Calculator09()
        {
            return View();
        }

        public IActionResult Calculator10()
        {
            return View();
        }

        public IActionResult Calculator11()
        {
            return View();
        }

        public IActionResult Calculator12()
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
