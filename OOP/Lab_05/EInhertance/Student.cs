using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInhertance
{
    internal class Student:Person
    {
        int grade;

        public void SetGrade(int _grade) { grade = _grade; }

        public int GetGrade() { return grade; }

        public Student() : base()
        {
            grade = 20;
        }


        public Student(int _id, string _name, int _age, int _grade) : base(_id, _name, _age)
        {
            SetGrade(_grade);
        }

        public override void Print()
        {
            Console.WriteLine($"Student :- {GetId()}   {GetName()}   {GetAge()}   {GetGrade()}");
        }
    }
}
