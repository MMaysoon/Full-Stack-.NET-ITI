using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Emp
    {
        //Delegate 

        //1.Step 1 (decalre event  for firing absent employee)
        public static event  Action<Emp> EmpFired;
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        int absentDays = 0;

        public int GetAbsentDays() => absentDays; 

        public void IncreaseAbsentDays () 
        {
            absentDays++;
            if (absentDays > 3)
            {
                //step_2 -> Fire event when absent > 3
                EmpFired?.Invoke(this);
            }
        }


        public void Print () => Console.WriteLine (ToString ());
        

        public override string ToString()
        {
            return $"{Id} : {Name} : {Age} : {absentDays}";
        }

        public override bool Equals(object? obj)
        {
           if (obj== null) return false;    
           if (obj.GetType() != GetType()) return false;
           Emp emp =(Emp)obj; // cast
           return Id==emp.Id && Name==emp.Name && Age==emp.Age;
        }

        
    }
}
