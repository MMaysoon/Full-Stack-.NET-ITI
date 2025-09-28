using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Ball_EventHandler
{
    internal struct Point
    {
        public int X {  get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $" ({X},{Y}) ";
        }


    }
}
