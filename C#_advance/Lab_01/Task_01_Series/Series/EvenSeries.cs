using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class EvenSeries : ISeries
    {
        private static int current = 2;

        public int GetCurrent()
        {
            int result = current;
            current += 2;
            return result;
        }
        public override string ToString()
        {
            return "Even Series";
        }
    }

}
