using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Emp
    {
        int id;
        string name;
        double salary;
        int age;

        public void SetId(int _id)
        {
            if (_id <= 0) 
                Console.WriteLine("ID must greater than 0");
            else id = _id;
        }

        public int GetId() { return id; }

        public void SetName(string _name)
        {
            if (_name.Length >= 3) name = _name;
            else Console.WriteLine("Invalid Name");
        }
        public string GetName() { return name; }

        public void SetSalary(double _salary)
        {
            if (_salary >0) salary = _salary;
            else Console.WriteLine("Invalid Salary");
        }
        public double GetSalary() { return salary; }


        public void SetAge(int _age)
        {
            if (_age >=25) age = _age;
            else Console.WriteLine("Invalid Age");
        }
        public int GetAge() { return age; }


        // Default const
        public Emp(int _id, string _name)
        {
            SetId(_id);
            SetName(_name);
            SetAge(30);
            SetSalary(6000);
        }

        public Emp(int _id, string _name, double _salary, int _age)
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
            SetSalary(_salary);
        }

        public Emp(int _id, string _name, int _age)
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
            SetSalary(6000);
        }

        public void Print()
        {
            Console.WriteLine($"ID:- {GetId()}  Name:- {GetName()}  Salary:- {GetSalary()}   Age:- {GetAge()} ");
        }
    }
}
