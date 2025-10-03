using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class Student
    {
       

        public string Name { get; set; }

        public int Id { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void NotifyExamStarted (object sender,SubjectEventArgs e)
        {
            Exam x= sender as Exam;
            Console.WriteLine($"Student {Name} (ID: {Id}) notified: Exam for {x.Subject.Name} has started! ");
        }

        public override string ToString() => $"{Name} (ID: {Id})";


    }
}
