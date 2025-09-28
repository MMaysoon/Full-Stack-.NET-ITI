namespace Task_2_TextWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileTxt<string> myList = new FileTxt<string>("C:\\Users\\user\\Desktop\\ITI\\C#_advance\\Lab_02\\Task_2_TextWriter\\Task_2_TextWriter\\data.txt");
            myList.Add("Maysoon");
            myList.Add("Ahmed");
            myList.Add("Hello World!");

            // items in memeory 
            Console.WriteLine("Items in memory:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
