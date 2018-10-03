using Dementors.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _db;

        public HomeController(DatabaseContext db)
        {
            this._db = db;
        }
        
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("CreateTrainingSession")]
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