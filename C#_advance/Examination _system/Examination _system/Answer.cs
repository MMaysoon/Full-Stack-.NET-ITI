using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class Answer:ICloneable
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        // Constructor Chaining (Default)
        public Answer():this(string.Empty,false) { }

        // Main Constructor
        public Answer(string _text , bool _IsCorrect)
        {
            Text= _text;
            IsCorrect = _IsCorrect;
        }

        // Copy by value not refrence (new object with same values)
        public object Clone() => new Answer(Text, IsCorrect);

        public override string ToString()
        {
            return $"{Text}{(IsCorrect ? "[✓]" : "")}";
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Answer;
            if (other == null) return false;
            return Text==other.Text && IsCorrect==other.IsCorrect;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text,IsCorrect);
        }
    }
}
