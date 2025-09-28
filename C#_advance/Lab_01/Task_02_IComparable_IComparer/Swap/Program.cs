namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp[] employees = {
            new Emp { Id = 3, Name = "Ali" },
            new Emp { Id = 1, Name = "Omar"},
            new Emp { Id = 2, Name = "Sara" },
            new Emp { Id = 5, Name = "may" }};

            //IComparable
            Console.WriteLine("IComparable----------");
            Array.Sort(employees);
            foreach(var e in employees)
            {
                Console.WriteLine($"Id ={e.Id} , Name = {e.Name} ");
            }

            // IComparer
            Console.WriteLine("IComparer by name------");
            Array.Sort(employees, new CompareByName());
            foreach (var e in employees)
            {
                Console.WriteLine($"Id ={e.Id} , Name = {e.Name} ");
            }

            Console.WriteLine("IComparer by id-------");
            Array.Sort(employees, new CompareById());
            foreach (var e in employees)
            {
                Console.WriteLine($"Id ={e.Id} , Name = {e.Name} ");
            }


        }
    }
}
