using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dementors.Model
{
	public class LoginInfos
	{
		[Key]
		public int UserId { get; set; }

		[Required(ErrorMessage = "Required.")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Required.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Required.")]
		[Compare("Password", ErrorMessage = "Passwords do not match.")]
		public string ConfirmPassword { get; set; }

	}
}
