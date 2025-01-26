using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ : Question
    {

        override public string ToString()
        {
            string output = $"{Header} Question \t {Mark} Marks \n\n{Body}\n\n";

            for (int i = 0; i < 3; i++)
            {
                output += $"{Answers[i].ToString()}\n";
            }

            return output;
        }
        //Deep Copy if needed
        public override object Clone()
        {
            Answer[] TempAnswers = new Answer[this.Answers.Length];
            for (int i = 0; i < this.Answers.Length; i++)
            {
                Answer a = this.Answers[i];
                TempAnswers[i] = new Answer(a.AnswerID, a.AnswerText);
            }

            return new MCQ
            {
                Header = this.Header,
                Body = this.Body,
                Mark = this.Mark,
                Answers = TempAnswers,
                CorrectAnswer = this.CorrectAnswer
            };
        }   
    }
}
