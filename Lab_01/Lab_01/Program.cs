using System;
namespace Lab_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region 1- Degree -> Excellent , very Good , Good , Pass, Fail
            Console.WriteLine("Example 1: Know Your Grade");
            Console.Write("Enter Your Degree :- ");
            int degree=int.Parse(Console.ReadLine());
            if (degree>=90)
            {
                Console.WriteLine("Excellent");
            }
            else if (degree >= 80)
            {
                Console.WriteLine("Very Good");
            }
            else if (degree >= 70)
            {
                Console.WriteLine("Good");
            }
            else if (degree >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("----------------------------------------------------------------\n");
            #endregion

            #region 2- Num -> Even or Odd
            Console.WriteLine("Example 2: Even or Odd");
            Console.Write("Enter Number :- ");
            int num=int.Parse(Console.ReadLine());
            if(num==0)
            {
                Console.WriteLine("Zero");
            }
            else if (num%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("----------------------------------------------------------------\n");
            #endregion

            #region 3- Factorial Number
            Console.WriteLine("Example 3: Factorial Number");
            Console.Write("Enter number :- ");
            int x = int.Parse(Console.ReadLine());
            int fact = 1;
            if (x==1 || x==0)
            {
                fact = 1;
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    fact *= i;
                }
            }
            
            Console.WriteLine($"The Factorial of Num {x} = {fact}");

            Console.WriteLine("----------------------------------------------------------------\n");
            #endregion

            #region 4-  Num1 , Num2 , op -> calc
            Console.WriteLine("Example 4: Calculator");
            Console.Write("Enter Num1 :- ");
            int num1=int.Parse(Console.ReadLine());
            Console.Write("Enter Num2 :- ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Operator :- ");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($" {num1} + {num2} = {num1+num2}");
                    break;
                case '-':
                    Console.WriteLine($" {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($" {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2!=0)
                    {
                        double result=(double)num1/num2;
                        Console.WriteLine($" {num1} / {num2} = {result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Can not divide by zero");
                        break;
                    }

                default:
                    Console.WriteLine(" Please! Enter Data in right format & Try Again");
                    break;
            }
            Console.WriteLine("----------------------------------------------------------------\n");
            #endregion

            #region 5- Prime Num -> yes or no 
            Console.WriteLine("Example 5:  Prime Number");
            Console.Write("Enter Number :- ");
            int p =int.Parse(Console.ReadLine());
            bool isPrime=true;

            if (p <= 1)
            {
                isPrime=false;
            }
            else
            {
                for (int i=2;i<p;i++)
                {
                    if (p%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }

            Console.WriteLine("----------------------------------------------------------------\n");
            #endregion

            #region 6- Accept 5 Num -> Print Sum
            Console.WriteLine("Example 6:  Sum");
            Console.WriteLine("Enter 5 Number --> ");
            int sum = 0;
            for (int i=1;i<=5;i++)
            {
                Console.Write($"Num {i} = ");
                int z=int.Parse(Console.ReadLine());
                sum += z;
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine("----------------------------------------------------------------\n");
            #endregion

        }
    }
}