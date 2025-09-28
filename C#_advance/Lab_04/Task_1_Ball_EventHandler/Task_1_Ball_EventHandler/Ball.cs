using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Ball_EventHandler
{
    class PostionChangedEventArgs
    {
        public int DeltaX { get; set; }
        public int DeltaY { get; set; }
    }
    internal class Ball
    {
        
        Point position;

        public event EventHandler<PostionChangedEventArgs> OnPostionChanged;

        internal Point Position
        {
            get => position;
   
        }

        public void SetPosition(int x,int y)
        {
            PostionChangedEventArgs e= new PostionChangedEventArgs() { DeltaX=position.X-x,DeltaY=position.Y-y};
            position.X = x;
            position.Y = y;
            OnPostionChanged.Invoke(this,e);
        }
        public override string ToString()
        {
            return $"ball position - {position}";
        }

    }
}
