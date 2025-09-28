using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Emp : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // IComparable
        public int CompareTo(object? obj)
        {
            Emp e =obj as Emp;
            if (e==null) return 1;
            return Id.CompareTo(e.Id);
        }

       

    }
}
