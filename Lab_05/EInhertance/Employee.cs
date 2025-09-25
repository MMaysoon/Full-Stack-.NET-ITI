using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInhertance
{
    internal class Employee :Person
    {
        int salary;

        public void SetSalary(int _salary) { salary = _salary; }

        public int GetSalary() { return salary; }

        public Employee() : base()
        {
            salary = 1000;
        }
        // ctor with inital value 
        public Employee(int _id = -1, string _name = "No Employee", int _age = -1, int _salary = 1000) : base(_id, _name, _age)
        {
            SetSalary(_salary);
        }

        public override void Print()
        {
            Console.WriteLine($"Employess :- {GetId()}   {GetName()}   {GetAge()}   {GetSalary()}");
        }
    }
}
