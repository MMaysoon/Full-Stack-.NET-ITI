using System;
using System.ComponentModel.DataAnnotations;
namespace Lab_02
{
    class program
    {
        public static void Main(string[] args)
        {
            #region 1-Menu (Add , Update , Exist)
            Console.WriteLine("--------------Menue----------------");
            Console.WriteLine("Menue ............");
            Console.WriteLine("A -> Add");
            Console.WriteLine("U -> Update");
            Console.WriteLine("E -> Exist");
            char ch;
            do
            {
                Console.Write("Enter Char :- ");
                ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Add");
                        break;
                    case 'u':
                    case 'U':
                        Console.WriteLine("Update");
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine("Exist");
                        break;
                    default:
                        Console.WriteLine("Invalid Input! , Enter One Char A or U ,E");
                        break;
                }

            } while (ch != 'e' && ch != 'E');
            Console.WriteLine("---------------------------------");


            #endregion

            #region 2-1D( Read, Display , Sum , Min , Max , Search)
            Console.WriteLine("--------------1D----------------");
            Console.Write("Enter the size of array :- ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];

            //1-Read 
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Array Num {i + 1} = ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //2-Display 
            Console.Write("Array -> ");
            for (int i = 0; i < arr1.Length; i++)
            {

                Console.Write($" {arr1[i]} ");
            }
            Console.WriteLine();

            //3-Sum 
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            Console.WriteLine($"Sum of array = {sum}");

            //4-Min 
            int min = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                    min = arr1[i];
            }
            Console.WriteLine($"The Minimum number = {min}");

            //5-Max
            int max = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                    max = arr1[i];
            }
            Console.WriteLine($"The Maximum number = {max}");

            //6-Searh By Index 
            Console.Write("Enter The index of value :- ");
            int x = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if ((x - 1) == i)
                {
                    Console.WriteLine($"The value of index {x} = {arr1[i]}");
                    found = true;

                }
            }
            if (found == false)
            {
                Console.WriteLine("Not Valid Index");
            }

            Console.WriteLine("--------------------------------");
            #endregion

            #region 3-Factorial Number 
            Console.WriteLine("--------------Factorial Number----------------");
            Console.Write("Enter number :- ");
            int num = int.Parse(Console.ReadLine());
            factNum(num);
            Console.WriteLine("--------------------------------");
            #endregion

            #region 4- Power
            Console.WriteLine("--------------Power----------------");
            Console.Write("Enter Num 1:- ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Enter Num 2:- ");
            int z = int.Parse(Console.ReadLine());
            power(w, z);
            Console.WriteLine("--------------------------------"); ;
            #endregion

            #region 5-Prime Number (T/F)
            Console.WriteLine("--------------Prime Number----------------");
            Console.Write("Enter Number :- ");
            int v = int.Parse(Console.ReadLine());
            bool isPrime = Prime(v);
            if (isPrime)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
            Console.WriteLine("--------------------------------");
            #endregion

            #region 6- get the n.of.prime befor number 
            Console.WriteLine("--------------n.of.prime befor number----------------");
            Console.Write("Enter Num :- ");
            int a = int.Parse(Console.ReadLine());
            nPrime(a);

            Console.WriteLine("--------------------------------");
            #endregion

            #region 7-Max Space between two similer number
            Console.WriteLine("--------------Max Space between two similer number----------------");
            Console.Write("Enter the size of array :-");
            int s = int.Parse(Console.ReadLine());
            int [] arr2=new int[s];
            Space(arr2);
            Console.WriteLine("--------------------------------");
            #endregion
        }





        #region 3-Factorial Number 
        static void factNum(int num)
        {
            int fact = 1;
            if (num == 1 || num == 0)
            {
                fact = 1;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    fact *= i;
                }
            }

            Console.WriteLine($"The Factorial of Num {num} = {fact}");
        }
        
        #endregion

        #region 4- Power
        static void power(int x,int y)
        {
            int p = 1;
            for(int i=0;i<y;i++)
            {
                p*= x;
            }
            Console.WriteLine($"{x} Power {y} = {p}");
        }
        #endregion

        #region 5-Prime Number (T/F)
        static bool Prime(int p)
        {
            bool isPrime = true;

            if (p <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

          return isPrime;
        }
        #endregion

        #region 6- get the n.of.prime befor number 
        static void nPrime(int p)
        {
            int len = 0;
            for (int i=2;i<p;i++)
            {
                bool isprime = Prime(i);
                if (isprime)
                {
                    len++;
                }
              
            }

            Console.WriteLine($"the Lenght : {len}");

             
        }
        #endregion

        #region 7-Max Space between two similer number
        static void Space (int[] arr)
        {
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write($"Enter Number {i} :- ");
                arr[i] = int.Parse( Console.ReadLine() );
            }

            int Mspace = 0;
            int z = 0;
            for (int i=0;i<arr.Length;i++)
            {
                for (int j=i+1;j<arr.Length-1;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        z = (j - i) - 1;
                        if (z>Mspace)
                        {
                            Mspace = z;
                        }
                    }
                }
            }
            Console.WriteLine(Mspace);
        }
        #endregion

    }
}