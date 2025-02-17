﻿using System;
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

        public override void ShowExam(Answer[] UserAnswers, TimeSpan elapsedTime)
        {
            Console.Clear();
            Console.WriteLine("Practical Exam: ");
            Console.WriteLine($"Time of the Exam: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}\n");

            for (int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine($"The Right Answer for Q{i+1} ===> {Questions[i].Answers[Questions[i].CorrectAnswer - 1].AnswerText}");
            }
            Console.WriteLine("\n============================================\n");
            Console.WriteLine($"Time : {elapsedTime}\nThank You");
        }
    }
}
