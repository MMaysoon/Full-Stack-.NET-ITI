using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal class CP
    {
        public double real;
        public double imagin;
        char sign = '+';

        public void SetSign()
        {
            if (imagin < 0)
            {
                sign = '-';
                imagin = imagin * -1;
            }
                
        }

        public char GetSign() { return sign; }




        public CP(double _real , double _imagin)
        {
            real=_real;
            imagin=_imagin;
            SetSign();
        }

        public void print ()
        {
            Console.WriteLine($"{real}{GetSign()}{imagin}i");
        }
    }
}
