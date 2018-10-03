using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
    public class HomeController : Controller
    {   
        
        public IActionResult Index()
        {
            return View();

        }
    }
}