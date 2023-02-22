using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_cj433.Models;
using System.Linq;

namespace Mission06_cj433.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _formContext { get; set; } // Add Context

        // Constructor
        public HomeController(MovieFormContext mvContext)
        {
            _formContext = mvContext;
        }

        // Index
        public IActionResult Index()
        {
            return View();
        }

        // Podcast
        public IActionResult Podcasts()
        {
            return View();
        }

        // Movie Form - Get
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _formContext.Categories
                .ToList();

            return View();
        }

        // Movie Form - Post
        [HttpPost]
        public IActionResult MovieForm (FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                _formContext.Add(fr);
                _formContext.SaveChanges();

                return View("Confirmation", fr);
            }
            else
            {
                ViewBag.Categories = _formContext.Categories.ToList();

                return View();
            }
        }

        // Movie List
        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = _formContext.Responses
                .Include(cat => cat.Category)
                .OrderBy(data => data.CategoryID)
                .ToList();

            return View(movies);
        }

        // Edit - Get
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _formContext.Categories.ToList();

            var movie = _formContext.Responses.Single(data => data.MovieID == movieid);

            return View("MovieForm", movie);
        }

        // Edit - Post
        [HttpPost]
        public IActionResult Edit(FormResponse fr, int movieid)
        {
            if (ModelState.IsValid)
            {
                _formContext.Update(fr);
                _formContext.SaveChanges();

                return RedirectToAction("MovieList", fr);
            }
            else
            {
                ViewBag.Categories = _formContext.Categories.ToList();
                var movie = _formContext.Responses.Single(data => data.MovieID == movieid);

                return View("MovieForm", movie);
            }
        }

        // Delete - Get
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var form = _formContext.Responses.Single(data => data.MovieID == movieid);

            return View(form);
        }

        // Delete - Post
        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            _formContext.Responses.Remove(fr);
            _formContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}