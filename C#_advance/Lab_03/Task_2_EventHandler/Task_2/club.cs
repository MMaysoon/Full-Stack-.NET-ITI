using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class club
    {
        public int clubId {  get; set; }

        public string clubName { get; set; }

        List<Emp> employess = new List<Emp>();  //compostion

        public void AddEmployee(Emp emp)
        {
            employess.Add(emp);
            Emp.EmpFired += RemoveEmployee;   //step 4 -> Subscribe to event 
        }

        public void RemoveEmployee(Emp emp)  //step 3 : Event Handler
        {
            employess.Remove(emp);
        }

        public void ListMembers()
        {
            Console.WriteLine($"--- {clubName} Members ---");
            foreach (var m in employess)
                Console.WriteLine(m);
        }

        public override string ToString()
        {
            return $"{clubId} : {clubName} : {employess.Count} members";
        }
    }
}
