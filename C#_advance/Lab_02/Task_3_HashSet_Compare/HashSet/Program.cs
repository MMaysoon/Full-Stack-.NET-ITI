namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();

            people.Add(new Person { Id = 1, Name = "Maysoon" });
            people.Add(new Person { Id = 2, Name = "Ahmed" });
            people.Add(new Person { Id = 1, Name = "Maysoon" });  //duplicate
            people.Add(new Person { Id = 1, Name = "Maysoon Ahmed" });  // change in name

            foreach(var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}
