using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string _header, string _body, double _marks, bool corresctIsTrue) : base(_header, _body, _marks)
        {
            Answers.Add(new Answer("True", corresctIsTrue));
            Answers.Add(new Answer("False", !corresctIsTrue));
        }

        public override object Clone()
        {
            bool correctTrue = Answers.Count > 0 && Answers[0].IsCorrect;
            return new TrueFalseQuestion(Header,Body,Marks,correctTrue);
        }

        public override void Display(int index)
        {
            Console.WriteLine($"{index}.{Header} ({Marks} mark)");
            if (!string.IsNullOrWhiteSpace(Body)) Console.WriteLine($"    {Body}");
            Console.WriteLine("   A) True");
            Console.WriteLine("   B) False");
        }

        public override double Grade(object studentResponse)
        {
            string resp = (studentResponse?.ToString() ?? string.Empty).Trim().ToLower();
            if (string.IsNullOrEmpty(resp)) return 0.0;
            bool pickedTrue = resp.StartsWith("t") || resp.StartsWith("a")||resp=="true";
            bool correct = Answers.Count > 0 && Answers[0].IsCorrect;
            return (pickedTrue == correct) ? Marks : 0.0;

        }
    }
}
