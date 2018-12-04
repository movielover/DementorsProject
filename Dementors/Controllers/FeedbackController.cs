using System;
using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
	[Route("Feedback")]
    public class FeedbackController : Controller
    {
        private readonly DatabaseContext _db;

        public FeedbackController(DatabaseContext db)
        {
            _db = db;
        }
           
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }   
        [HttpPost()]
        public IActionResult Create(Feedback feedback)
        {

            if (!ModelState.IsValid)
                return View();

            feedback.UserId = 1;
            feedback.Id = 1;
            feedback.TimeDate = DateTime.Now;

            _db.Feedback.Add(feedback);
            _db.SaveChanges(); 
            
            return View();
        }
    }
}