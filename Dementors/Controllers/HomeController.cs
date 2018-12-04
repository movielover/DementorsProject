using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
	[Route("Home")]
    public class HomeController : Controller
    {   
        
        public IActionResult Index()
        {
            return View();

        }
    }
}