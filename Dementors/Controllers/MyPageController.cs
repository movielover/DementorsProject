using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dementors.Entities;
using Dementors.Model;

namespace Dementors.Controllers
{
    [Route("Mypage")]
    public class MyPageController : Controller
    {
        private readonly DatabaseContext _context;

        public MyPageController(DatabaseContext context)
        {
            _context = context;
        }
		[HttpGet("users")]
		public ActionResult Index()
		{
			//List<Bruger> users = new List<Bruger>();
			//foreach (var user in _context.User)
			//{
			//	users.Add(user);
			//}
			//var user_ = _context.User.FirstOrDefault(c => c.Id == id);
			ViewBag.users = _context.User;
			return View();
		}

	}
}