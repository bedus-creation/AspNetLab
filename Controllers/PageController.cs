using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sms.Models;

namespace Sms.Controllers
{
    public class PageController : Controller
    {
        private readonly ILogger<PageController> _logger;

        public PageController(ILogger<PageController> logger)
        {
            _logger = logger;
        }

        public String Index()
        {
            return "This is my default action...";
        }

        public String Blogs()
        {
            return "This is my blogs";
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
