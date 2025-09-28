using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // 1-Hashcode
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        //2.Equals
        public override bool Equals (object obj)
        {
            // can cast
            if(obj is Person other) 
                return this.Id==other.Id && this.Name==other.Name;
            return false;

        }

        //3.tostring
        public override string ToString()
        {
            return $"Id={Id}, Name={Name}";
        }
    }
}
