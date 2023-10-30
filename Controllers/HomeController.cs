using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Website_pessoal.Models;

namespace Website_pessoal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //referencia acrescentada
        public IActionResult Index()
        {
            return View();
        }
        //referencia acrescentada
        public IActionResult SobreMim()
        {
            return View();
        }
        //referencia acrescentada
        public IActionResult Formacao()
        {
            return View();
        }
        //referencia acrescentada
        public IActionResult Interesses()
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