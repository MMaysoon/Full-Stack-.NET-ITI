using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle :Shape
    {
        public Rectangle() : base() { }
       

        public Rectangle(int _dim) : base(_dim) { }

        public Rectangle(int _dim1, int _dim2):base(_dim1,_dim2) { }

        public override void CalArea()
        {
            Console.WriteLine($"Rectangle Area = {GetDim1()*GetDim2()}");
        }
        
            
      


    }
}
