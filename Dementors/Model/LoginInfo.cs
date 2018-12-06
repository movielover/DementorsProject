using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dementors.Model
{
	public class LoginInfo
	{

		public string Username { get; set; }
		public string Password { get; set; }
		[ForeignKey("User")]
		public int UserId { get; set; }
	}
}
