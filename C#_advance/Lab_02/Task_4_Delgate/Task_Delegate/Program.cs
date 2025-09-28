
namespace Task_Delegate
{
    // 1.Declare Delegate
    delegate int del (int x,int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.Normal Delegate
            static int Add(int x , int y)
                { return x + y; }

            del addDel = Add;
            Console.WriteLine("Normal Delegate -> Add: " + addDel(10, 5));


            //3.Anoymous delegate 
            del subDel = delegate (int x, int y)
            {
                return x - y;
            };
            Console.WriteLine("Anonymous Delegate -> Sub: " + subDel(10, 5));

            //5.Lambda delegate
            del mulDel = (x, y) => x * y;
            Console.WriteLine("Llambda Delegate -> Multiply: " + mulDel(10, 5));

            //Built-in Delegate------

            //6.Func delegate (return value)
            Func<int,int,int> divide=(x,y) => x / y;
            Console.WriteLine("Func : "+divide(10, 5));

            //7.Action (no return value)
            Action<int,int> printSum =(x,y) => Console.WriteLine("Action Sum = "+(x+y));
            printSum(5, 4);

            //8.Predicate (one paramter & return boolean)
            Predicate<int> isEven = n => n % 2==0;
            Console.WriteLine("Is 10 even? " + isEven(10));
            Console.WriteLine("Is 5 even? " + isEven(5));

        }
    }
}
