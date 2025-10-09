using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tags
    {
        public int TagsId { get; set; }
        public string Name { get; set; }

        // Many to Many with Books
        public ICollection<BookTag> BookTags { get; set; }
    }
}
