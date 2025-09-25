using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fract
    {
        int numerator;
        int denominator;

        public void SetNumerator(int _nomerator) { numerator = _nomerator; }
        public void SetNDenominator(int _denominator)
        { 
            if (_denominator ==0)
            {
                Console.WriteLine("Invalid ! Denominator Must not equal zero");
            }
            else
            {
                denominator = _denominator;
            }    
        }

        public int GetNumerator() { return numerator; }

        public int GetNDenominator() { return denominator; }


        public Fract()
        {
            SetNumerator(1);
            SetNDenominator(1);
        }

        public Fract(int _nemorator , int _demonrator)
        {
            SetNumerator(_nemorator);
            SetNDenominator(_demonrator);
        }

        public Fract(int _nemorator)
        {
            SetNumerator(_nemorator);
            SetNDenominator(1);
        }

        public void Print ()
        {
           Simplify();
        }

        public void Simplify ()
        {
            int max = 1;
            for (int i=2;((i<=denominator) && (i<=numerator));i++)
            {
                if ( (numerator%i==0) && (denominator%i==0 ))
                {
                   if (i>max)
                    {
                        max = i;
                    }
                }
            }

            numerator /= max;
            denominator /= max;
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }
}
