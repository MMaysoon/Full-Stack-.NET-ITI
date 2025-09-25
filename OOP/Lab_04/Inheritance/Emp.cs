using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Emp:Person
    {
        int salary;

        public void SetSalary(int _salary) { salary = _salary; }

        public int GetSalary() { return salary; }

        public Emp():base()
        {
            salary = 1000;
        }
        public Emp(int _id, string _name, int _age, int _salary) : base(_id, _name, _age)
        {
            SetSalary(_salary);
        }

        public void PrintE()
        {
            Console.WriteLine($"{GetId()}   {GetName()}   {GetAge()}   {GetSalary()}");
        }
    }
}
