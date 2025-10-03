using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal abstract class Question: ICloneable,IComparable<Question>
    {
        public string Header { get; }
        public string Body { get; }
        public double Marks { get; }

        public AnswerList Answers { get; set; }

        public Question(string _header) : this(_header, string.Empty, 1.0) { }

        public Question(string _header,string _body,double _marks)
        {
            Header = _header;
            Body = _body;
            Marks = _marks;
            Answers=new AnswerList();
        }

        public abstract void Display(int index);

        public abstract double Grade(object studentResponse);

        public abstract object Clone();
        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            int m=Marks.CompareTo(other.Marks);
            if (m != 0) return m;
            return string.Compare(Header,other.Header,StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{Marks} mark] {Header} - {Body}");

            char opt = 'A';
            foreach (var ans in Answers)
            {
                sb.AppendLine($"   {opt}) {ans.Text} {(ans.IsCorrect ? "[✓]" : "")}");
                opt++;
            }

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Question;
            if (other == null) return false;
            return Header == other.Header && Body == other.Body && Marks == other.Marks;
        }

        public override int GetHashCode() => HashCode.Combine(Header, Body, Marks);
    }
}
