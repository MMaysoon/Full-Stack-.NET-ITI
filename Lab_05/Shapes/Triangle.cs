using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle:Shape
    {
        public Triangle() : base() { }
        

        public Triangle(int _dim) : base(_dim) { }

        public Triangle(int _dim1, int _dim2) : base(_dim1, _dim2) { }

        public override void CalArea()
        {
            Console.WriteLine($"Triangle Area = {0.5* GetDim1() * GetDim2()}");
        }
    }
}
