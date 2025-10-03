using System;

namespace Examination__system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Subject
            Subject Math = new Subject("Math", "M101");
            Subject Physics = new Subject("Physics", "P202");

            //2.Question
            QuestionList mathQ = new QuestionList("C:\\Users\\user\\Desktop\\ITI\\C#_advance\\Exams\\Math.txt")
            {
               new TrueFalseQuestion("(2 + 2) = 4?", "", 5, true),
                new ChooseOneQuestion("What is 5 * 3?", "", 5, new List<Answer>
                {
                    new Answer("10", false),
                    new Answer("15", true),
                    new Answer("20", false)
                }),
                new ChooseAllQuestion("Which of the following numbers are prime?", "", 10, new List<Answer>
                {
                    new Answer("2", true),
                    new Answer("3", true),
                    new Answer("4", false),
                    new Answer("5", true),
                    new Answer("6", false)
                })
            };
            mathQ.Dispose();
           

           
            QuestionList physicsQ = new QuestionList("C:\\Users\\user\\Desktop\\ITI\\C#_advance\\Exams\\Physics.txt")
            {
                new TrueFalseQuestion("The Earth orbits the Sun?", "", 5, true),

                new ChooseOneQuestion("What is H2O commonly called?", "", 5, new List<Answer>
                {
                    new Answer("Water", true),
                    new Answer("Oxygen", false),
                    new Answer("Hydrogen", false)
                }),

                new ChooseAllQuestion("Which of these are planets?", "", 10, new List<Answer>
                {
                    new Answer("Mercury", true),
                    new Answer("Venus", true),
                    new Answer("Moon", false),
                    new Answer("Earth", true),
                    new Answer("Sun", false)
                })
            };
            
            physicsQ.Dispose();


            //3.Student 
            Student s1 = new Student("Maysoon", 1);
            Student s2 = new Student("Menah", 2);


            //4.Exam for each subject
            Exam practiceMathExam = new PracticeExam(Math, TimeSpan.FromMinutes(1), mathQ);
            Exam finalMathExam = new FinalExam(Math, TimeSpan.FromMinutes(30), mathQ);

            Exam practicePhysicsExam = new PracticeExam(Physics, TimeSpan.FromMinutes(25), physicsQ);
            Exam finalPhysicsExam = new FinalExam(Physics, TimeSpan.FromMinutes(35), physicsQ);

            //5.Student Subscribe in event
            practiceMathExam.ExamStarted +=  s1.NotifyExamStarted;
            practiceMathExam.ExamStarted +=  s2.NotifyExamStarted;

            finalMathExam.ExamStarted +=  s1.NotifyExamStarted;
            finalMathExam.ExamStarted += s2.NotifyExamStarted;

            practicePhysicsExam.ExamStarted += s1.NotifyExamStarted;
            practicePhysicsExam.ExamStarted +=  s2.NotifyExamStarted;

            finalPhysicsExam.ExamStarted +=  s1.NotifyExamStarted;
            finalPhysicsExam.ExamStarted +=  s2.NotifyExamStarted;

            //6.Exam 😂
            Console.WriteLine("============================= Examination System =============================\n");
            Console.WriteLine("Choose Subject:");
            Console.WriteLine("1) Math");
            Console.WriteLine("2) Physics");
            Console.Write("Your chosen : ");
            int subjectChoice;
            while (!int.TryParse(Console.ReadLine(), out  subjectChoice) || (subjectChoice < 1 || subjectChoice > 2))
            {
                Console.WriteLine("Invalid input! Please enter 1 for Math or 2 for Physics.");
            }
            Console.WriteLine("\n");


            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1) Practice Exam");
            Console.WriteLine("2) Final Exam");
            Console.Write("Your chosen : ");
            int examChoice;
            while (!int.TryParse(Console.ReadLine(), out examChoice) || (examChoice < 1 || examChoice > 2))
            {
                Console.WriteLine("Invalid input! Please enter 1 for Practice or 2 for Final.");
            }
            Console.WriteLine("\n");


            Exam chosenExam;
            //Math
            if (subjectChoice==1)
            {
                chosenExam = (examChoice == 1) ? practiceMathExam : finalMathExam;
            }
            else //Physics
            {
                chosenExam = (examChoice == 1) ? practicePhysicsExam : finalPhysicsExam;
            }


            //7.Exam Flow (MODE)
            //Console.WriteLine($"=== Exam selected: {chosenExam.Subject.Name} , {chosenExam.GetType().Name} ===");
            //Console.WriteLine($"\nExam Mode: {chosenExam.Mode}");

            //// 1.Queued
            //if (chosenExam.Mode == ExamMode.Quequed)
            //    Console.WriteLine("❌ You cannot take the exam while it is in Queued mode!\n");


            //// 2.Start
            chosenExam.StartExam();
            Console.WriteLine($"Exam Mode Now: {chosenExam.Mode}\n");

            // Start exam
            Console.WriteLine($"============================ Exam  {chosenExam.Subject.Name} , {chosenExam.GetType().Name} ============================");
            chosenExam.ShowExam();

            //// 3.Finish 
            //chosenExam.FinishExam();
            //Console.WriteLine($"Exam Mode: {chosenExam.Mode}");

        }
    }
}
