using System.Text.RegularExpressions;

namespace Task_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
              List<string> s = ["maysoon", "menah", "ahmed", "ibrahim", "may","xxxxmayxx"];

              //1-Length >3
              var res1 = s.FindCustom(a => a.Length > 3);
              Console.WriteLine("Names with lenght > 3 ------------ ");
              foreach (var item in res1)
              {
                Console.WriteLine(item);
              }

            //2-start with "m"
            var res2 = s.FindCustom( a => Regex.IsMatch(a, @"^m"));
            Console.WriteLine("Names start with m ---------------- ");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }

            //3-end with "d"
            var res3 = s.FindCustom( a => Regex.IsMatch(a, @"d$"));
            Console.WriteLine("Names with end with d------------- ");
            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }

            //4-conatins  "may"
            var res4 = s.FindCustom( a => Regex.IsMatch(a, @"may"));
            Console.WriteLine("Names contains 'may' ---------------");
            foreach (var item in res4)
            {
                Console.WriteLine(item);
            }

        }
    }
}
