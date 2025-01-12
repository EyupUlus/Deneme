
using System.Diagnostics;
using Frontend.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class PagesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PagesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
        public IActionResult blogs() => View();
        public IActionResult faqs() => View();
        public IActionResult pricing() => View();
        public IActionResult profile() => View();
        public IActionResult starter() => View();
        public IActionResult timeline() => View();
        public IActionResult treeview() => View();
    }
}