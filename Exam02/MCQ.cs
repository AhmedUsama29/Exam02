using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ : Question
    {
        //change
        public override string ToString()
        {
            var answersString = Answers != null
                ? string.Join("\n", Answers.Select((a, index) => $"{index + 1}. {a}"))
                : "No answers available.";

            return $"Header: {Header}\n" +
                   $"Body: {Body}\n" +
                   $"Mark: {Mark}\n" +
                   $"Answers:\n{answersString}\n" +
                   $"Correct Answer: {CorrectAnswer}";
        }
    }
}
