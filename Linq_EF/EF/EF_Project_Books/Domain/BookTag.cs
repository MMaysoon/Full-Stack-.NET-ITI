using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BookTag
    {
        public int BookId;
        public Books Book;

        public int TagId;
        public Tags Tag {  get; set; }
    }
}
