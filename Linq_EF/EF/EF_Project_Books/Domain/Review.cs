using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string VectorName { get; set; }
        public int NumStars { get; set; }
        public String Comment { get; set; }

        // Many to one with Books
        public int BookId { get; set; }
        public Books Book { get; set; }
    }
}
