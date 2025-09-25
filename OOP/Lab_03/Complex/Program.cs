using Complex;
namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Part 1:- ");
            double x=double.Parse(Console.ReadLine());
            Console.Write("Enter Part 2:- ");
            double y=double.Parse(Console.ReadLine());

            CP c=new CP(x,y);
            c.print();
        }
    }
}