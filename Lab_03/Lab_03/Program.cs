using System;
namespace Lab_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region 1-Swap 
            Console.WriteLine("-----------Swap--------------");
            Console.Write("Enter Number 1:- ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2:- ");
            int b = int.Parse(Console.ReadLine());
            //Swap(ref a, ref b);
            Swap(ref a, ref b);
            Console.WriteLine($"Number 1= {a}  Number 2= {b}");
            Console.WriteLine("------------------------------");
            #endregion


            #region 2-Array
            Console.WriteLine("-----------1D--------------");
            Console.Write("Enter array size :- ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr1(n, arr);
            Console.WriteLine("------------------------------");
            #endregion  



        }

        #region 1-Swap
        static void Swap(ref int a , ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            a = 50;   //  ref effect
           
        }
        #endregion

        #region 2-Array
        static void arr1(int n ,  int[]arr)
        {
           

            // 1-Accept Data 
            for (int i=0;i<n;i++)
            {
                Console.Write($"Enter Num {i+1} :- ");
                arr[i]=int.Parse(Console.ReadLine());
            }

            // 2-ref 
            arr[0] = 9999;

            //3-Display 
            Console.Write("Array -> ");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write($" {arr[i]} ");
            }
            Console.WriteLine();

            //4-Sum 
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum of array = {sum}");

        }
        #endregion
    }
}