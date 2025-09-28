using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class CompareById : IComparer<Emp>
    {
        public int Compare(Emp x, Emp y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
    
    
}
