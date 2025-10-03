using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class PracticeExam:Exam
    {

        public PracticeExam(Subject subject,TimeSpan duration ,QuestionList questions)
            : base(subject, duration, questions) 
        {
            
        }

        public override void ShowExam()
        {
            if (Mode != ExamMode.Starting)
            {
                Console.WriteLine("❌ Exam Not Started !");
                return;
            }
            double totalScore = 0;

            for (int i=0;i<Questions.Count;i++)
            {
                Questions[i].Display(i + 1);
                Console.Write("Your Answer: ");
                string ans=Console.ReadLine();

                double score = Questions[i].Grade(ans);
                totalScore += score;

                // add ans
                StudentAnswers[Questions[i]] = new Answer(ans, score > 0);

                // show correct answer
                Console.Write($"Correct Answer : ");
                foreach(var a in Questions[i].Answers)
                {
                    if (a.IsCorrect) Console.Write($" {a.Text} ");
                }
                Console.WriteLine($"\nYou got: {score}/{Questions[i].Marks}\n");

            }

            Console.WriteLine($"Final Score = {totalScore}/{Questions.Sum(q => q.Marks)}");



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

            PracticeExam copy = new PracticeExam(newSub, Duration, newQuestions);
            copy.StudentAnswers = newStudentAnswers;
            copy.Mode = this.Mode;
            return copy;
        }
    }
}
