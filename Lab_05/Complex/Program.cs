using Complex;
using System;
namespace Lab_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("...........Complex 1...........");
            Console.Write("Enter Part 1:- ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Part 2:- ");
            int y = int.Parse(Console.ReadLine());
            Cp c1 = new Cp(x, y);

            Console.WriteLine("...........Complex 2...........");
            Console.Write("Enter Part 1:- ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Part 2:- ");
            int b = int.Parse(Console.ReadLine());
            Cp c2 = new Cp(a, b);

            #region Class Equality
            Console.WriteLine("...........................Class (Refrence Type)...........................");
            Console.WriteLine("Before :-");
            c1.Print();
            c2.Print();

            c1 = c2;
            c1.SetReal(500);
            Console.WriteLine("Ref Euality Class................");
            Console.WriteLine("After change in complex 1 (a by 500 )");
            c1.Print();
            c2.Print();
            #endregion

            #region Struct Value Equality
            Console.WriteLine("...........................Struct (Value Type)...................................");
            CpStruct c3 = new CpStruct(x, y);
            CpStruct c4 = new CpStruct(a, b);
            Console.WriteLine("Before :-");
            c3.Print();
            c4.Print();

            c3 = c4;
            c3.SetReal(500);
            Console.WriteLine("Value Equality Struct................");
            Console.WriteLine("After change in complex 1 (a by 500 )");
            c3.Print();
            c4.Print();
            #endregion

            #region Struct with Ref Equality
            Console.WriteLine("...........................Apply Ref  in Struct (Value Type)...................................");
            Console.WriteLine("...........................Struct (Value Type)...................................");
            CpStruct c5 = new CpStruct( x,  y);
            ref CpStruct c6 = ref c5;
            Console.WriteLine("Before :-");
            c5.Print();
            c6.Print();

            c5.SetReal(1400);
            Console.WriteLine("Ref Equality for  Struct................");
            Console.WriteLine("After change in complex 1 (a by 1400 )");
            c5.Print();
            c6.Print();
            #endregion

            #region count
            Console.WriteLine("...........................COUNT...................................");
            Console.WriteLine(Cp.GetCount() + CpStruct.GetCount());
            #endregion

            #region Operator OverLoad
            Console.WriteLine("...........................Operator OverLoad...................................");
            int real1 = 5;
            int imag1 = 6;

            int real2 = 3;
            int imag2 = 2;

            Cp c12 = new Cp(real1, imag1);
            Cp c13 = new Cp(real2, imag2);

            Cp c14 = c12 + c13;
            Cp c15 = c12 - c13;

            Console.Write($"Addation : ");
            c14.Print();
            Console.Write($"Subtraction : ");
            c15.Print();
            Console.WriteLine($"Equality :  {c14 == c15}");
            #endregion
        }
    }
}