using System;
namespace Complex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Complex 1...........");
            Console.Write("Enter Part 1:- ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Part 2:- ");
            int y =int.Parse(Console.ReadLine());
            Cp c1=new Cp(x,y);

            Console.WriteLine("Complex 2...........");
            Console.Write("Enter Part 1:- ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Part 2:- ");
            int b = int.Parse(Console.ReadLine());
            Cp c2 = new Cp(a, b);


            Console.WriteLine("Class...................................");
            Console.WriteLine("Before :-");
            c1.Print();
            c2.Print();

            c1 = c2;
            c1.SetReal(500);
            Console.WriteLine("Ref Euality Class................");
            Console.WriteLine("After change in complex 1 (a by 500 )");
            c1.Print();
            c2.Print();


            Console.WriteLine("Struct...................................");
            CpStruct c3=new CpStruct(x,y);
            CpStruct c4=new CpStruct(a,b);
            Console.WriteLine("Before :-");
            c3.Print();
            c4.Print();

            c3 = c4;
            c3.SetReal(500);
            Console.WriteLine("Value Equality Struct................");
            Console.WriteLine("After change in complex 1 (a by 500 )");
            c3.Print();
            c4.Print();




        }
    }
}