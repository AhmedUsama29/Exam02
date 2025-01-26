using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        

        public short Time { get; set; }
        public short NumOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        private Stopwatch examStopwatch;

        public Exam(short time, short numOfQuestions)
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
            Questions = new Question[numOfQuestions];
            examStopwatch = new Stopwatch();
        }

        public void StartExam() 
        {
            Console.Clear();
            Console.WriteLine($"Time of the Exam: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}\n");

            Answer[] UserAnswers = new Answer[NumOfQuestions];
            short counter = 0;

            examStopwatch.Start();
            foreach (Question question in Questions)
            {

                // check if the exam time is done
                if (examStopwatch.Elapsed.TotalMinutes >= (double)Time)
                {
                    Console.WriteLine("\nTime's up! The exam will now end.\n");
                    break;
                }


                Console.WriteLine(question);
                short AnswerId = question is MCQ ? Helper.GetAnswerForMCQ() : Helper.GetAnswerForTrueOrFalse();
                UserAnswers[counter++] = new Answer(AnswerId, question.Answers[AnswerId-1].AnswerText);
                Console.WriteLine("\n============================================\n");
            }

            examStopwatch.Stop();
            ShowExam(UserAnswers, examStopwatch.Elapsed);
        }

        public abstract void ShowExam(Answer[] userAnswers, TimeSpan elapsedTime);

    }
}
