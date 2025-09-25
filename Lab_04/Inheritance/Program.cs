using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Person-------");
            Person p= new Person();
            Person p2 = new Person(2, "Maysoon", 24);
            Console.Write("Default ctor :- ");
            p.Print();
            Console.Write("Oveload ctor :- ");
            p2.Print();


            Console.WriteLine("---Student------");
            student s=new student();
            Console.Write("Default ctor :- ");
            s.PrintS();
            student s2=new student(2, "Maysoon", 24,25);
            Console.Write("Oveload ctor :- ");
            s2.PrintS();



            Console.WriteLine("---Employee-----");
            Emp emp=new Emp();
            Console.Write("Default ctor :- ");
            emp.PrintE();
            Emp emp2=new Emp(2, "Maysoon", 24, 20000);
            Console.Write("Oveload ctor :- ");
            emp2.PrintE();
        }
    }
}