using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal static class Helper
    {
        public static short GetExamType()
        {
            short ExamType;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final)");
                flag = short.TryParse(Console.ReadLine(), out ExamType);
            } while (!flag || (ExamType != 1 && ExamType != 2));
            return ExamType;
        }

        public static short GetExamTime()
        {
            short ExamTime;
            bool flag;
            do
            {
                Console.WriteLine("Please enter the time for the exam (from 30 min to 180 min):");
                flag = short.TryParse(Console.ReadLine(), out ExamTime);
            } while (!flag || (ExamTime < 30 || ExamTime > 180));
            return ExamTime;
        }

        public static short GetNumberOfQuestions()
        {
            short NumberOfQuestions;
            bool flag;
            do
            {
                Console.WriteLine("Please enter the number of questions:");
                flag = short.TryParse(Console.ReadLine(), out NumberOfQuestions);
            } while (!flag || NumberOfQuestions <= 0);
            return NumberOfQuestions;
        }

        public static string GetQuestionType()
        {
            int QuestionType;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter Type of Question (1 for MCQ | 2 for True or False):");
                flag = int.TryParse(Console.ReadLine(), out QuestionType);
            } while (!flag || (QuestionType != 1 && QuestionType != 2));

            return QuestionType == 1 ? "MCQ" : "True | False";
        }

        public static short GetQuestionMark()
        {
            short QuestionMark;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the Question Mark:");
                flag = short.TryParse(Console.ReadLine(), out QuestionMark);
            } while (!flag || QuestionMark <= 0);

            return QuestionMark;
        }

        public static MCQ GetMCQDetails()
        {
            string questionBody;
            do
            {
                Console.WriteLine("MCQ Question \nPlease Enter Question Body:");
                questionBody = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(questionBody));

            short mark = GetQuestionMark();
            Answer[] answers = GetChoices();

            short CorrectAnswer;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the Correct Answer ID:");
                flag = short.TryParse(Console.ReadLine(), out CorrectAnswer);
            } while (!flag || CorrectAnswer <= 0 || CorrectAnswer > 3);

            return new MCQ()
            {
                Body = questionBody,
                Mark = mark,
                Answers = answers,
                CorrectAnswer = CorrectAnswer
            };
        }

        public static Answer[] GetChoices()
        {
            string choice;
            Answer[] answers = new Answer[3];

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine($"Please Enter Choice Number {i+1}:");
                    choice = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(choice));

                answers[i] = new Answer()
                {
                    AnswerID = (short)i+1,
                    AnswerText = choice
                };

            }

            return answers;

        }

    }
}
