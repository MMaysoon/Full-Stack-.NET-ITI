using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Ball_EventHandler
{
    internal class Referee
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Referee : {Name}";
        }

        public void MoveReferee(object sender, PostionChangedEventArgs e)
        {
            Player p = sender as Player;
            Console.WriteLine($"from referee {this} :: Player position changed  {p}");
        }
    }
}
