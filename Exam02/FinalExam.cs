using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(short time, short numOfQuestions) : base(time, numOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            Console.WriteLine($"Time of the Exam: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}\n");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question);

            }
        }


    }
}
