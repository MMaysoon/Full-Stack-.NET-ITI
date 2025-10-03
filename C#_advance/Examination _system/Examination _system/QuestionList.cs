using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class QuestionList:List<Question>,IDisposable
    {
        private StreamWriter writer;
        private bool firstWrite = true;
        public string LogFileName { get; set; }


        public QuestionList(string _logFileName)
        {
            LogFileName = _logFileName;
            writer = new StreamWriter(LogFileName, false);
        }

        // Override add (it not virtual so using new)
        public new void Add(Question question)
        {
            // 1. Add in list 
            base.Add(question);

            // 2. Append in file using StreamWriter
            try
            {
                if (firstWrite)
                {
                    writer.WriteLine(question.ToString());
                    firstWrite = false;
                }
                else
                {
                    writer.WriteLine(question.ToString());
                }

                writer.Flush(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing question: " + ex.Message);
            }
        }

        public void Dispose()
        {
            if (writer != null)
            {
                writer.Flush();
                writer.Close();
                writer = null;
            }
        }
    }
}
