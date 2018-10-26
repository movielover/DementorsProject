using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        
        [Route(" ")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost, Route("Create")]
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