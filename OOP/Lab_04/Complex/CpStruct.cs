using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal struct CpStruct
    {
        int real;
        int imaginary;

        public void SetReal(int _real) { real = _real; }
        public void SetImg(int _imaginary) { imaginary = _imaginary; }

        public int GetReal() { return real; }

        public int GetImg() { return imaginary; }

        public CpStruct(int _real, int _img)
        {
            SetReal(_real);
            SetImg(_img);
        }

        public void Print()
        {
            if (imaginary > 0)
            {
                Console.WriteLine($"{real}+{imaginary}j");
            }
            else if (imaginary < 0)
            {
                Console.WriteLine($"{real}{imaginary}j");
            }
            else
            {
                Console.WriteLine($"{real}j");
            }
        }


    }
}
