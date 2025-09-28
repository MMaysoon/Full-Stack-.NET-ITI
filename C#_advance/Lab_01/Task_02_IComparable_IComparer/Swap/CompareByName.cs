using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class CompareByName : IComparer<Emp>
    {
        public int Compare(Emp x, Emp y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
    
    
}
