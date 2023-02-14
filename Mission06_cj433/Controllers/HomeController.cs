using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_cj433.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_cj433.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext _formContext { get; set; }

        // Constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext mvContext)
        {
            _logger = logger;
            _formContext = mvContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm (FormResponse r)
        {
            if (ModelState.IsValid)
            {
                _formContext.Add(r);
                _formContext.SaveChanges();
                return View("Confirmation", r);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}