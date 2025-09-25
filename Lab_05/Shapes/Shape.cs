using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class Shape
    {
        int dim1;
        int dim2;

        public void SetDim1(int _dim1) => dim1 = _dim1;
        public int GetDim1() => dim1;

        public void SetDim2(int _dim2) => dim2 = _dim2;
      
        public int GetDim2() => dim2;

        public Shape()
        {
            dim1 = dim2 = 1;
        }

        public Shape(int dim)
        {
            dim1=dim2 = dim;
        }

        public Shape(int _dim1 , int _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }

        public abstract void CalArea();
        
    }
}
