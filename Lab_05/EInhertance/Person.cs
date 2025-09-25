using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInhertance
{
    internal abstract class Person
    {
        int Id;
        string Name;
        int age;

        public void SetId(int _id) { Id = _id; }
        public void SetName(string _name) { Name = _name; }
        public void SetAge(int _age) { age = _age; }

        public int GetId() { return Id; }

        public string GetName() { return Name; }

        public int GetAge() { return age; }


        public Person()
        {
            Name = "no person name";
            Id = -1;
            age = 0;
        }


        // ctoe with intial value
        public Person(int _id=-1, string _name="no Person name", int _age = -1)
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
        }

        public abstract void Print();
       
    }
}
