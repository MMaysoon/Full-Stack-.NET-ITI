using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class student :Person
    {
        int grade;

        public void SetGrade(int _grade) { grade = _grade;}

        public int GetGrade() { return grade; }

        public student():base()
        {
            grade = 20;
        }
        
            
       

        public student(int _id , string _name , int _age ,int _grade) :base(_id,_name ,_age)
        {
            SetGrade(_grade);
        }

        public void PrintS()
        {
            Console.WriteLine($"{GetId()}   {GetName()}   {GetAge()}   {GetGrade()}");
        }
    }
}
