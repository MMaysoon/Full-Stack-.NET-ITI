using System;
namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dim 1 :- ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("Enter Dim 2 :- ");
            int y = int.Parse(Console.ReadLine());

            #region rectangle with diff ctor
            Console.WriteLine("-----Rectangle-----");
            Rectangle r1 = new Rectangle();
            Rectangle r2= new Rectangle(x);
            Rectangle r3 = new Rectangle(x,y);
            Console.Write($"Rectangle with Default ctor :-  ");
            r1.CalArea();
            Console.Write($"Rectangle with 1 paramter ctor :-  ");
            r2.CalArea();
            Console.Write($"Rectangle with 2 paramter ctor :-  ");
            r3.CalArea();
            #endregion

            #region triangle with diff ctor
            Console.WriteLine("-----Triangle------");
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(x);
            Triangle t3 = new Triangle(x,y);
            Console.Write($"Triangle with Default ctor :-  ");
            t1.CalArea();
            Console.Write($"Triangle with 1 paramter ctor :-  ");
            t2.CalArea();
            Console.Write($"Triangle with 2 paramter ctor :-  ");
            t3.CalArea();
            #endregion



            #region Generic
            Console.WriteLine("-----Generic------");
            // shape abstract class get refrence to child class 
            Shape s1 = new Rectangle(x,y);
            Shape s2=new Triangle(x,y);
            GShape(s1);
            GShape(s2);
            #endregion


        }

        //Generic Func 
        public static  void GShape(Shape s)
        {
            s.CalArea();
        }
    }
}
