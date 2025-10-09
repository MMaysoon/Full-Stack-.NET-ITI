using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BookAuthor
    {
        public int BookId;
        public Books Book;

        public int AuthorId;
        public Author Author;

        public int Order { get; set; }
    }
}
