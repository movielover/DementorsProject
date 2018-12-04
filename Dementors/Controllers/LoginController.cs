using Dementors.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dementors.Controllers
{
	public class LoginController : Controller
	{

		public IActionResult Index()
		{
			return View();

		}
	}
}