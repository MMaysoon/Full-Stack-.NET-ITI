using System;
namespace EInhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student with diff ctor
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---Student------");
            Student s = new Student();
            Console.Write("Default ctor :- ");
            s.Print();
            Student s2 = new Student(2, "Maysoon", 24, 25);
            Console.Write("Oveload ctor :- ");
            s2.Print();
            Console.WriteLine("------------------------------------------------------");
            #endregion


            #region Employee with diff ctor
            Console.WriteLine("---Employee-----");
            Employee emp = new Employee();
            Console.Write("Default ctor :- ");
            emp.Print();
            Employee emp2 = new Employee(2, "Maysoon", 24, 20000);
            Console.Write("Oveload ctor :- ");
            emp2.Print();
            Console.WriteLine("------------------------------------------------------");
            #endregion

            #region Employee with ctor take inital value
            Console.WriteLine("---Employee with ctor have intial value -----");
            Employee emp3 = new Employee(2);
            Console.Write("with 1 Paramter :- ");
            emp3.Print();
            Employee emp4 = new Employee(2, "Maysoon");
            Console.Write("with 2 Paramter :- ");
            emp4.Print();
            Employee emp5 = new Employee(2, "Maysoon", 24);
            Console.Write("with 3 Paramter :- ");
            emp5.Print();
            Console.WriteLine("------------------------------------------------------");
            #endregion

            #region Ref by Ref
            Console.WriteLine("---Apply Quality Refrence By Refrence -----");
            Console.WriteLine("---Before assigning---");
            Employee e1 = new Employee(10, "Maysoon", 24, 6000);
            Employee e2 = new Employee(40, "May", 22 ,5000);
            e1.Print();
            e2.Print();
            Console.WriteLine($"Reference Equal? (empA == empB): {object.ReferenceEquals(e1, e2)}");

            Console.WriteLine("\n---After assigning empA = empB---");
            e2 = e1;
            e2.SetName("Change?!");    // changes affect in both
            e1.Print();
            e2.Print();
            Console.WriteLine($"Reference Equal? (empA == empB): {object.ReferenceEquals(e1, e2)}");
            #endregion

            #region Count
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("----------------Generic-----------------");
            PGenric(new Employee(10, "Maysoon", 24, 6000));
            PGenric(new Student(2, "Maysoon", 24, 25));
            #endregion




        }

        public static void PGenric(Person p)
        {
            p.Print();
        }
    }
}