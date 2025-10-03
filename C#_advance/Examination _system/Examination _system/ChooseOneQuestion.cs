using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class ChooseOneQuestion:Question
    {
        public ChooseOneQuestion(string header,string body ,double marks , List<Answer> options)
            :base (header,body,marks)
        {
            if (options!=null)
            {
                for (int i = 0;i<options.Count; i++)
                {
                    Answers.Add((Answer)options[i].Clone());
                }
            }
        }

        public override object Clone()
        {
            return new ChooseOneQuestion(Header,Body,Marks,Answers);
        }

        public override void Display(int index)
        {
            Console.WriteLine($"{index}. {Header} ({Marks} mark)");
            if (!string.IsNullOrWhiteSpace(Body)) Console.WriteLine($"   {Body}");
            char opt= 'A';
            for (int i=0;i<Answers.Count;i++)
            {
                Console.WriteLine($"  {opt}) {Answers[i].Text}");
                opt++;
            }
        }

        public override double Grade(object studentResponse)
        {
            string resp = (studentResponse?.ToString() ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(resp)) return 0.0;
            char c = char.ToUpper(resp[0]);

            // check enter answer char A,b,C
            if (c >= 'A' && c < 'A' + Answers.Count)
            {
                int idx = c - 'A';
                return Answers[idx].IsCorrect ? Marks : 0.0;
            }

            // check enter answer text
            for(int i=0;i<Answers.Count; i++)
            {
                if (String.Equals(Answers[i].Text, resp, StringComparison.OrdinalIgnoreCase)) 
                {
                    return Answers[i].IsCorrect ? Marks : 0.0;
                }
            }

            return 0.0;

        }
    }
}
