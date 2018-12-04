using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Dementors.Model
{
    public class Bruger
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

    }
}
