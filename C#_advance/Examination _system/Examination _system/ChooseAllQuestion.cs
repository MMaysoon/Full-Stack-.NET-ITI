using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class ChooseAllQuestion:Question
    {
        public ChooseAllQuestion(string header, string body, double marks, List<Answer> options)
        : base(header, body, marks)
        {
            if (options != null)
            {
                for (int i = 0; i < options.Count; i++)
                    Answers.Add((Answer)options[i].Clone());
            }
        }

        public override void Display(int index)
        {
            Console.WriteLine($"{index}. {Header} ({Marks} mark)");
            if (!string.IsNullOrWhiteSpace(Body)) Console.WriteLine($"   {Body}");
            char opt = 'A';
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"   {opt}) {Answers[i].Text}");
                opt++;
            }
            Console.WriteLine("Choose more one by using Sperated comma (,)");
        }
        public override object Clone() => new ChooseAllQuestion(Header, Body, Marks, Answers);

        public override double Grade(object studentResponse)
        {
            string resp = (studentResponse?.ToString() ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(resp)) return 0.0;

            string[] parts = resp.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            HashSet<int> picked =new HashSet<int>();

            // check enter char answers between answer char
            for (int i = 0; i < parts.Length; i++)
            {
                string p = parts[i].Trim();
                if (p.Length == 0) continue;

                //1.Enter (text)
                bool matched = false;
                for (int j = 0; j < Answers.Count; j++)
                {
                    if (string.Equals(Answers[j].Text.Trim(), p.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        picked.Add(j);
                        matched = true;
                        break;
                    }
                }
                if (matched) continue;

                //2.Enter (A,b,c....) 
                char first = char.ToUpper(p[0]);
                if (first >= 'A' && first < 'A' + Answers.Count)
                {
                    picked.Add(first - 'A');
                    continue;
                }






            }

            // Correct 
            HashSet<int> correctIndexes =new HashSet<int>();
            for(int i=0;i<Answers.Count;i++)
            {
                if (Answers[i].IsCorrect)
                {
                    correctIndexes.Add(i);
                }    
            }

            if (picked.SetEquals(correctIndexes))
            {
                Console.WriteLine("Picked: " + string.Join(",", picked));
                Console.WriteLine("Correct: " + string.Join(",", correctIndexes));
                return Marks;
            }
            else
            {
                Console.WriteLine("Picked: " + string.Join(",", picked));
                Console.WriteLine("Correct: " + string.Join(",", correctIndexes));
                return 0.0;
            }

            
        }
    }
}
