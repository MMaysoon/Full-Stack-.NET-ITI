using System;
namespace Fraction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Enumerator :- ");
            int x= int.Parse(Console.ReadLine());

            Console.Write("Enter Denominator :- ");
            int y = int.Parse(Console.ReadLine());


            // 1-Default Constructor 
            Fract f1 = new Fract();
            Console.Write("Default Constructor :- ");
            f1.Simplify();

            Console.Write("Default Constructor  with Set Paramter:- ");
            Fract f2 = new Fract();
            f2.SetNumerator(x);
            f2.SetNDenominator(y);
            f2.Simplify();


            // 2-Constructor Get only Numerator
            Fract f3 = new Fract(x);
            Console.Write("Constructor Get only Numerator:- ");
            f3.Simplify();

            // 2-Constructor Get both
            Fract f4 = new Fract(x,y);
            Console.Write("Constructor Get both :- ");
            f4.Simplify();
        }
    }
}