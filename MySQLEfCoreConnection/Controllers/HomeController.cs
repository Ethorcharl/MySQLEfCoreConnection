using Microsoft.AspNetCore.Mvc;
using MySQLEfCoreConnection.Data;
using MySQLEfCoreConnection.Models;
using System.Diagnostics;

namespace MySQLEfCoreConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyDBContext _context;
        public HomeController(ILogger<HomeController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var people = _context.Person.ToList();
            return View(people);
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