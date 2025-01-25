using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(short time, short numOfQuestions) : base(time, numOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam: ");
            Console.WriteLine($"Time of the Exam: {Time} minutes"); // change to hours and minutes later
            Console.WriteLine($"Number of Questions: {NumOfQuestions}\n");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question);
            }
        }
    }
}
