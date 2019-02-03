using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restauranter.Models;
using Microsoft.EntityFrameworkCore;

namespace restauranter.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        // private object _context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Review rev)
        {
            if(ModelState.IsValid)
            {
                Review newReview = new Review
                {
                    name = rev.name,
                    restaurant = rev.restaurant,
                    stars = rev.stars,
                    review = rev.review,
                    date_visit = rev.date_visit,
                };
                _context.Add(newReview);
                _context.SaveChanges();
                return RedirectToAction("Reviews");
            }
            else
            {
                // ViewBag.allReviews = allReviews;
                return View("Index");
            }
        }

        public IActionResult Reviews()
        {
            List<Review> allReviews = _context.Review.ToList();
            return View(allReviews);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
