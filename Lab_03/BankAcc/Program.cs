using BankAcc;
namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Id :- ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name :- ");
            string name = Console.ReadLine();
            Console.Write("Enter the Balance :- ");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------");
            Bank b1 = new Bank(id, name, balance);
            Console.WriteLine("-------------------------------");

            // Check have withdraw , deposite or not 
            Console.WriteLine("Have withdraw , deposite or not ?  ");
            Console.Write("Enter Char -> W  OR  D OR  N  :-  ");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'W':
                case 'w':
                    Console.Write("Enter The amount of withdraw :- ");
                    double withdraw = double.Parse(Console.ReadLine());
                    balance = balance - withdraw;
                    break;
                case 'D':
                case 'd':
                    Console.Write("Enter The amount of deposite :- ");
                    double deposite = double.Parse(Console.ReadLine());
                    balance = balance + deposite;
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("OK");
                    break;
                default:
                    break;
            }

            

            // print
            b1.Print();

        }
    }
}