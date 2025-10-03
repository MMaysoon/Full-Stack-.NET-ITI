using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    class SubjectEventArgs:EventArgs
    {
        public Subject Subject { get; }

        public SubjectEventArgs(Subject subject)
        {
            Subject = subject;
        }
    }
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {

        // Event when exam starts
        public event EventHandler<SubjectEventArgs> ExamStarted;
        public Subject Subject { get; set; }

        public TimeSpan Duration { get; set; }

        public ExamMode Mode { get; protected set; } = ExamMode.Quequed;

        public QuestionList Questions { get; set; }

        public Dictionary<Question,Answer> StudentAnswers { get; set; }=new Dictionary<Question,Answer>();

        public Exam(Subject subject, TimeSpan duration, QuestionList questions)
        {
            Subject = subject;
            Duration = duration;
            Questions = questions;
        }

       
        public abstract void ShowExam();

        //Invoke Starts Event 
        public virtual void StartExam()
        {
            if (Mode != ExamMode.Quequed)
            {
                Console.WriteLine("⚠️ Exam Queued");
                return;
            }
            Mode =ExamMode.Starting;
            SubjectEventArgs e=new SubjectEventArgs(this.Subject);
            ExamStarted?.Invoke(this,e);
        }

       

        public virtual void FinishExam()
        {
            if (Mode != ExamMode.Starting)
            {
                Console.WriteLine("⚠️ Exam Not Started");
                return;
            }

            Mode = ExamMode.Finished;
            Console.WriteLine("✅ Exam Finished");
        }

        public override string ToString()
        {
            return $"Exam: {Subject}, Duration: {Duration.TotalMinutes} mins, Mode: {Mode}, Questions: {Questions.Count}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Exam other)
            {
                return Subject.Code == other.Subject.Code && Duration == other.Duration;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Subject.Code, Duration);
        }
        public abstract object Clone();


        public int CompareTo(Exam? other)
        {
            if (other == null) return 1;
            return Duration.CompareTo(other.Duration);

        }

        
    }
}
