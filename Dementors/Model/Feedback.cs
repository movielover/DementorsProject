using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dementors.Model
{
    public class Feedback
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime TimeDate { get; set; }
    }
}
