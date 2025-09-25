using System;
namespace Duration
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes, seconds;
            Time t = null;
            Console.WriteLine("Choose Num 1 OR 2 ");
            Console.WriteLine("1-Enter Hours : Seconds : Minutes \n2-Enter only Seconds");
            Console.Write("Enter Num : ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("Enter Hours : ");
                    hours = int.Parse(Console.ReadLine());
                    Console.Write("Enter Minutes : ");
                    minutes = int.Parse(Console.ReadLine());
                    Console.Write("Enter Seconds : ");
                    seconds = int.Parse(Console.ReadLine());
                    t = new Time(hours, minutes, seconds);
                    break;
                case 2:
                    Console.Write("Enter Total Seconds : ");
                    seconds = int.Parse(Console.ReadLine());
                    t = new Time(seconds);
                    break;
                default:
                    break;
            }

            //ToString
            Console.WriteLine($"Time is : {t}");


            #region Operator
            Time t3 = new Time(1, 59, 30); 
            Time t4 = new Time(90);        

            Time sum = t3 + t4;
            Console.WriteLine("Sum is : " + sum);      

            t4++;
            Console.WriteLine("After ++ : " + t4);
            #endregion
        }
    }
}