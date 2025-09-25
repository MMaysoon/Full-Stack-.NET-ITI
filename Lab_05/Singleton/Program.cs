using System;
namespace Singleton
{
    class Progrm
    {
        public static void Main(string[] args)
        {
            Student s1 = Student.CreateStudent(2, "maysoon");
            Student s2 =Student.CreateStudent(14, "menah");

            Console.WriteLine($"S1: {s1}");
            Console.WriteLine($"S2: {s2}");

            Console.WriteLine($"S1 HashCode: {s1.GetHashCode()}");
            Console.WriteLine($"S2 HashCode: {s2.GetHashCode()}");
        }
    }
}