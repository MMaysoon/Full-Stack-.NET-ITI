using System;
namespace Fraction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fraction One");
            Console.Write("Enter Enumerator :- ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Denominator :- ");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("Fraction Two");
            Console.Write("Enter Enumerator :- ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Denominator :- ");
            int b = int.Parse(Console.ReadLine());



            #region Diff Constructor 
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
            Fract f4 = new Fract(x, y);
            Console.Write("Constructor Get both :- ");
            f4.Simplify();
            #endregion

            #region Operator Overload
            Fract f5 = new Fract(x, y);
            Fract f6 = new Fract(a, b);

            Console.Write("Addition : ");
            Fract result = f5 + f6;
            result.Print();

            Console.Write("Subtraction : ");
            Fract result2 = f5 - f6;
            result2.Print();

            Console.Write("Multiplication : ");
            Fract result3 = f5 * f6;
            result3.Print();

            Console.Write("Divison : ");
            Fract result4 = f5 / f6;
            result4.Print();
            #endregion
        }
    }
}