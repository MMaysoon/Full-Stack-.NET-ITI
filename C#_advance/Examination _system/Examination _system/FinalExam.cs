using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class FinalExam:Exam
    {
        public FinalExam(Subject subject, TimeSpan duration, QuestionList questions)
           : base(subject, duration, questions)
        {

        }

        public override void ShowExam()
        {

            double totalScore = 0;
            double totalMarks = 0;

            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].Display(i + 1);
                Console.Write("Your Answer: ");
                string ans = Console.ReadLine();
                Console.WriteLine("\n");

                double score = Questions[i].Grade(ans);

                // add ans
                StudentAnswers[Questions[i]] = new Answer(ans, score > 0);

                totalScore += score;
                totalMarks += Questions[i].Marks;

            }

            Console.WriteLine($"\nYour Final Score: {totalScore} out of {totalMarks}");

        }

        public override object Clone()
        {
            Subject newSub = new Subject(Subject.Name, Subject.Code);

            QuestionList newQuestions = new QuestionList(Questions.LogFileName);

            foreach (var q in Questions)
                newQuestions.Add((Question)q.Clone());

            var newStudentAnswers = new Dictionary<Question, Answer>();
            foreach (var x in StudentAnswers)
                newStudentAnswers.Add((Question)x.Key.Clone(), (Answer)x.Value.Clone());

            FinalExam copy = new FinalExam(newSub, Duration, newQuestions);
            copy.StudentAnswers = newStudentAnswers;
            copy.Mode = this.Mode;
            return copy;
        }
    }
}
