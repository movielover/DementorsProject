using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Dementors.Model
{
    public class Bruger
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
		public string City { get; set; }
		public int Zip { get; set; }
		public int Phone { get; set; }

	}
}
