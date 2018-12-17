using System;
using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly DatabaseContext _db;

        public FeedbackController(DatabaseContext db)
        {
            _db = db;
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            if (!ModelState.IsValid)
                return View();

            feedback.TimeDate = DateTime.Now;

            _db.Feedback.Add(feedback);
            _db.SaveChanges(); 
            
            return View();
        }
    }
}