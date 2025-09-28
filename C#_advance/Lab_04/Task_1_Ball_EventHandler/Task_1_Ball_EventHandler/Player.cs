using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Ball_EventHandler
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //1.player position
        Point position;

        //2.Event for change in position 
        public event EventHandler<PostionChangedEventArgs> OnPlayerdMoved;

        //3.method determine the changed in player position
        public void SetPlayerPosition(int x,int y)
        {
            PostionChangedEventArgs e = new PostionChangedEventArgs()
            {
                DeltaX = position.X - x,
                DeltaY = position.Y - y
            };

            position.X = x; position.Y = y;

            //call event
            OnPlayerdMoved.Invoke(this, e);
        }
        public override string ToString()
        {
            return $"{Id}-{Name}";
        }

        // move player when changed ball position
        public void MovePlayer(object sender,PostionChangedEventArgs e)
        {
            Ball b1=sender as Ball;
            Console.WriteLine($"from player {this} :: ball position changed  {b1.Position}");
        }
    }
}
