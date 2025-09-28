using System.Runtime.Intrinsics.X86;

namespace Task_1_Ball_EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball() { };

            Player p1=new Player() { Id=1,Name="mosalah"};
            Player p2=new Player() { Id=2,Name="mesi"};
            Player p3=new Player() { Id=3,Name="mo"};
            Player p4=new Player() { Id=4,Name="fathy"};
            Referee r1 = new Referee() { Name = "x" };
            Referee r2 = new Referee() { Name = "m" };

            Console.WriteLine("-----Ball&Player-------");
            //Registration player in event ball position
            ball.OnPostionChanged += p1.MovePlayer;
            ball.OnPostionChanged += p3.MovePlayer;
            ball.OnPostionChanged += p4.MovePlayer;
           

            ball.SetPosition(10, 20);
            Console.WriteLine("After replacment (remove p1)-------");
            ball.OnPostionChanged-=p1.MovePlayer;
            ball.SetPosition(50, 40);

            Console.WriteLine("-----Player&Refree-------");
            p1.OnPlayerdMoved += r1.MoveReferee;
            p2.OnPlayerdMoved += r2.MoveReferee;

            p1.SetPlayerPosition(10,20);
            p2.SetPlayerPosition(10,20);







        }
    }
}
