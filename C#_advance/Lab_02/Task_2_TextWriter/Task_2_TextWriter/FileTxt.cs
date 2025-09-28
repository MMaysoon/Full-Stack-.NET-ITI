using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_TextWriter
{
    internal class FileTxt <t> : List<t>
    {
        private string filePath;

        public FileTxt(string path)
        {
            filePath = path;
        }

        public new void Add(t item )
        {
            //1.Add to memeory
            base.Add(item);

            //2.Add to file
            using(StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(item);
            }

           
        }
    }
}
