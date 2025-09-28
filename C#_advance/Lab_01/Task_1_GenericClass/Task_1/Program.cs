namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> l1=new MyList<string>();
            l1.Add("may");
            l1.Add("mays");
            l1.Add("mayso");
            l1.Add("maysoo");
            l1.Add("maysoon");
            l1.Print();
            Console.WriteLine("count : "+l1.Count);
            Console.WriteLine("capacity : "+l1.Capaity);
            Console.WriteLine("------------------------");

           //duplicate capacity
            l1.Add("ahmed");
            Console.WriteLine("count : " + l1.Count);
            Console.WriteLine("capacity : " + l1.Capaity);

            // using indexer
            Console.WriteLine($"Index[0] = {l1[0]}"); 
            Console.WriteLine($"Index[4] = {l1[4]}"); 
            l1[4] = "changed";
            Console.WriteLine($"Index[2] after change = {l1[4]}");

            //Remove by value 
            Console.WriteLine("Data before remove----");
            l1.Print();
            l1.RemoveByvalue("mayso");
            Console.WriteLine("Data after remove------");
            l1.Print();
        }
    }
}
