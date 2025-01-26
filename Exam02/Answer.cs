using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Answer //: IComparable // didn't need because i used Hepler.GetMark()
    {
        public Answer(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        }

        public int AnswerID { get; set; }
        public string AnswerText { get; set; }

        override public string ToString()
        {
            return $"{AnswerID}){AnswerText}";
        }

    }
}
