namespace Swap
{
    internal class Program
    {
        static void Swap<t1>(ref t1 x,ref t1 y) where t1:IComparable
        {
            t1 temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            //1.Swap integer (error if add constraint class)
            int a = 10, b = 20;
            Swap(ref a,ref b);
            Console.WriteLine($"a={a} , b={b}");

            //2.Swap float (error if add constraint class) 
            float x = 5.2f, y= 3.2f;
            Swap(ref x, ref y);
            Console.WriteLine($"x={x} , y={y}");

            //3.Swap string (Refrence type work well with class) (error if add constraint struct)
            string s1 = "maysoon", s2="ahmed";
            Swap(ref s1, ref s2);
            Console.WriteLine($"s1={s2} , s1={s2}");


            //4.Swap employees (error if add constraint struct)
            Emp e1 = new Emp { Id = 3, Name = "Ali" };
            Emp e2 = new Emp { Id = 1, Name = "Omar" };
            Swap(ref e1, ref e2);
            Console.WriteLine(e1.Name + "  " + e2.Name);



        }
    }
}
