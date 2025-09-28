using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Department
    {
        public int DeptId { get; set; } 
        public string DeptName { get; set; }

        List<Emp> employess =new List<Emp>();  //compostion

        public void AddEmployee(Emp emp)
        {
            employess.Add(emp);
            Emp.EmpFired += RemoveEmployee;   //step 4 -> Subscribe to event 
        }

        public void RemoveEmployee (Emp emp)  //step 3 : Event Handler
        {
            employess.Remove(emp);
        }

        public override string ToString()
        {
            return $"{DeptId} :  {DeptName} : {employess.Count}";
        }

        public void ListEmployees()
        {
            Console.WriteLine($"--- {DeptName} Employees ---");
            foreach (var e in employess)
                Console.WriteLine(e);
        }
    }
}
