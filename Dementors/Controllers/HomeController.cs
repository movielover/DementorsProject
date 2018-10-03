using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
    public class HomeController : Controller
    {   
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}