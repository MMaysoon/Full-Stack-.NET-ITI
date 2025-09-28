using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal static class Extenstions
    {
        public static List<string> FindCustom(this List<string> s, Func<string, bool> cond)
        {
            var res = new List<string>();
            foreach (var item in s)
            {
                if (cond.Invoke(item))
                    res.Add(item);
            }
            return res;
        }
    }
}
