using Employee;
using System;
namespace Lab_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter Id :- ");
            int id=int.Parse(Console.ReadLine());
            Console.Write("Enter Name :- ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary :- ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Age :- ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            // 1-Ctor Emp(int _id, string _name, double _salary, int _age) & apply Set and get
            Console.WriteLine("----Constructor 1-------");
            Emp e1 = new Emp(id, name, salary, age);


            // 2-Ctor Emp(int _id, string _name, int _age)
            Console.WriteLine("----Constructor 2-------");
            Emp e2 = new Emp(id, name, age);


            // 3-Ctor Emp(int _id, string _name)
            Console.WriteLine("----Constructor 3-------");
            Emp e3 = new Emp(id, name);
            Console.WriteLine("------------------------------");


            

            // Check have withdraw , deposite or not 
            Console.WriteLine("Have withdraw , deposite or not ?  ");
            Console.Write("Enter Char -> W  OR  D OR  N  :-  ");
            char ch = char.Parse(Console.ReadLine());
            switch(ch)
            {
                case 'W':
                case 'w':
                    Console.Write("Enter The amount of withdraw :- ");
                    double withdraw=double.Parse(Console.ReadLine());
                    e1.SetSalary(e1.GetSalary() - withdraw);
                    break;
                case 'D':
                case 'd':
                    Console.Write("Enter The amount of deposite :- ");
                    double deposite = double.Parse(Console.ReadLine());
                    e1.SetSalary(e1.GetSalary() + deposite);
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("OK");
                    break;
                default:
                    break;
            }

           
       


            // print 
            Console.WriteLine("----Constructor 1-------");
            e1.Print();
            Console.WriteLine("----Constructor 2-------");
            e2.Print();
            Console.WriteLine("----Constructor 3-------");
            e3.Print();






        }
    }
}