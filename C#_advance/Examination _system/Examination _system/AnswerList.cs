using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination__system
{
    internal class AnswerList:List<Answer>
    {
        public AnswerList() : base() { }

        public AnswerList(List<Answer>answers):base()
        {
            if (answers != null)
            {
                for(int i=0;i<answers.Count;i++)
                {
                    this.Add((Answer)answers[i].Clone());
                }
            }
        }

        public List<Answer> GetCorrectAnsweres()
        {
            List<Answer> corretAnswers = new List<Answer>();
            for (int i=0;i<this.Count;i++)
            {
                if (this[i] .IsCorrect)
                {
                    corretAnswers.Add(this[i]);
                }
            }
            return corretAnswers;

        }
    }
}
