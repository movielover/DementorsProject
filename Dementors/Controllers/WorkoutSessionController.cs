using System;
using Dementors.Model;
using Microsoft.AspNetCore.Mvc;
using Dementors.Entities;

namespace Dementors.Controllers
{
    public class WorkoutSessionController : Controller
    {
        private readonly DatabaseContext _db;

        public WorkoutSessionController(DatabaseContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Save(WorkoutSession workoutSession)
        {
            if (!ModelState.IsValid)
                return View();
            
            workoutSession.TimeDateForWorkout = DateTime.Now;

            _db.WorkoutSession.Add(workoutSession);
            _db.SaveChanges(); 
            
            return View();
        }
    }
}