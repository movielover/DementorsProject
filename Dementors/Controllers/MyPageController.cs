using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dementors.Entities;

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
			//foreach(var user in _context.User)
			//{
			//	users.Add(user);
			//}
			//ViewData["user"] = users;
			ViewBag.users = _context.User;
			return View();
		}

		//// GET: api/MyPage/5
		//[HttpGet("{id}")]
		//public async Task<IActionResult> GetBruger([FromRoute] int id)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    var bruger = await _context.User.FindAsync(id);

		//    if (bruger == null)
		//    {
		//        return NotFound();
		//    }

		//    return Ok(bruger);
		//}

		//// PUT: api/MyPage/5
		//[HttpPut("{id}")]
		//public async Task<IActionResult> PutBruger([FromRoute] int id, [FromBody] Bruger bruger)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    if (id != bruger.)
		//    {
		//        return BadRequest();
		//    }

		//    _context.Entry(bruger).State = EntityState.Modified;

		//    try
		//    {
		//        await _context.SaveChangesAsync();
		//    }
		//    catch (DbUpdateConcurrencyException)
		//    {
		//        if (!BrugerExists(id))
		//        {
		//            return NotFound();
		//        }
		//        else
		//        {
		//            throw;
		//        }
		//    }

		//    return NoContent();
		//}

		//// POST: api/MyPage
		//[HttpPost]
		//public async Task<IActionResult> PostBruger([FromBody] Bruger bruger)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    _context.User.Add(bruger);
		//    await _context.SaveChangesAsync();

		//    return CreatedAtAction("GetBruger", new { id = bruger.Id }, bruger);
		//}

		//// DELETE: api/MyPage/5
		//[HttpDelete("{id}")]
		//public async Task<IActionResult> DeleteBruger([FromRoute] int id)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    var bruger = await _context.User.FindAsync(id);
		//    if (bruger == null)
		//    {
		//        return NotFound();
		//    }

		//    _context.User.Remove(bruger);
		//    await _context.SaveChangesAsync();

		//    return Ok(bruger);
		//}

		//private bool BrugerExists(int id)
		//{
		//    return _context.User.Any(e => e.Id == id);
		//}
	}
}