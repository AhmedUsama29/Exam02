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


        public override void ShowExam(Answer[] UserAnswers, TimeSpan elapsedTime)
        {
            Console.WriteLine("Final Exam:");
            Console.WriteLine($"Time of the Exam: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}\n");
            int counter = 0;

            foreach (Question question in Questions)
            {
                Console.WriteLine(question);
                Console.WriteLine($"The Right Answer ===> {question.CorrectAnswer}");
                Console.WriteLine($"Your Answer ===> {UserAnswers[counter].AnswerText}");
                
                double UserMark = Helper.GetMark(question, UserAnswers[counter++]);

                Console.WriteLine($"Your Grade is {UserMark} from {question.Mark}");
            }
            Console.WriteLine($"Time : {elapsedTime}\nThank You");
        }


    }
}
