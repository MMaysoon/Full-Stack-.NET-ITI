using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Student
    {
        int id;
        string name;

        // 1- private static feild to hold the single instance 
        private static Student student=null;

        // 2- Private Ctor to bock "new"
        private Student(int _id, string _name)
        {
           id = _id;
          name = _name;
        }

        // 3- Public static method 
        public static Student CreateStudent (int _id, string _name)
        {
            if (student == null)
            {
                student=new Student(_id, _name);
            }
            return student;
        }

        public override string ToString()
        {
            return $"Student with Id:{id} and name:{name}";
        }
    }
}
