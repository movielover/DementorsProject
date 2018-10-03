using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
    public class WorkoutSeanceController : Controller
    {
        private readonly DatabaseContext _db;

        public WorkoutSeanceController(DatabaseContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("CreateWorkoutSeance")]
        public IActionResult CreateWorkoutSeance(WorkoutSeance workoutSeance)
        {
            if(!ModelState.IsValid)
                return View();

            _db.WorkoutSeance.Add(workoutSeance);
            _db.SaveChanges();

            return View();

        }
    }
}