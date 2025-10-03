using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Subject(string name , string code)
        {
            Name= name;
            Code= code;
        }

        public override string ToString()
        {
            return $"{Name} {Code}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Subject other)
                return Code == other.Code; 
            return false ;
        }

        public override int GetHashCode() => Code.GetHashCode();
    }
}
