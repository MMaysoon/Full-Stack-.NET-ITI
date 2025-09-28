using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class OddSeries : ISeries
    {
        private static int current = 1;  // static to be shared across all OddSeries object

        public int GetCurrent()
        {
            int result = current;
            current += 2;
            return result;
        }

        public override string ToString()
        {
            return "Odd Series";
        }
    }
}
