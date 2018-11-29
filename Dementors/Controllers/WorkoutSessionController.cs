using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

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
        
        [Route("SaveWorkoutSession")]
        public IActionResult SaveWorkoutSession(WorkoutSession workoutSession)
        {
            if(!ModelState.IsValid)
                return View();

            _db.WorkoutSession.Add(workoutSession);
            _db.SaveChanges();

            return View();

        }
    }
}