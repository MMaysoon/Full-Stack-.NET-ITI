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
            if (_denominator == 0)
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

        #region Diff Ctor
        public Fract()
        {
            SetNumerator(1);
            SetNDenominator(1);
        }

        public Fract(int _nemorator, int _demonrator)
        {
            SetNumerator(_nemorator);
            SetNDenominator(_demonrator);
        }

        public Fract(int _nemorator)
        {
            SetNumerator(_nemorator);
            SetNDenominator(1);
        }

        #endregion

        #region Operator OverLoad
        public static  Fract operator +(Fract f1, Fract f2)
        {
           Fract f=new Fract();
           f.numerator = (f1.numerator*f2.denominator) + (f1.denominator*f2.numerator);
            f.denominator = f1.denominator * f2.denominator;
            return f;
        }

        public static Fract operator -(Fract f1, Fract f2)
        {
            Fract f = new Fract();
            f.numerator = (f1.numerator * f2.denominator) - (f2.numerator * f1.denominator);
            f.denominator = f1.denominator * f2.denominator;
            return f;
        }
        public static Fract operator *(Fract f1, Fract f2)
        {
            Fract f = new Fract();
            f.numerator = (f1.numerator * f2.numerator) ;
            f.denominator = f1.denominator * f2.denominator;
            return f;
        }
        public static Fract operator /(Fract f1, Fract f2)
        {
            Fract f = new Fract();
            f.numerator = (f1.numerator * f2.denominator) ;
            f.denominator = f1.denominator * f2.numerator;
            return f;
        }
        #endregion


        #region Simplify 
        public void Print()
        {
          
           Simplify();
        }

        public void Simplify()
        {
            if (denominator == 0)
            {
                Console.WriteLine("Invalid! Denominator must not be zero.");
                return;
            }

            if (numerator == 0)
            {
               
                Console.WriteLine("0");
                return;
            }
            int max = 1;
            for (int i = 2; ((i <= denominator) && (i <= numerator)); i++)
            {
                if ((numerator % i == 0) && (denominator % i == 0))
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
            }

            numerator /= max;
            denominator /= max;
            Console.WriteLine($"{numerator}/{denominator}");
        }
        #endregion
    }
}
