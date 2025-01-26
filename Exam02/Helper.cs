using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal static class Helper    //For validation and getting user input
    {
        #region Creation of Exam
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
        #endregion

        #region MCQ

        public static MCQ CreateMcqQuestion()
        {
            string QuestionBody;
            do
            {
                Console.WriteLine("MCQ Question \nPlease Enter Question Body:");
                QuestionBody = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(QuestionBody));

            double mark = GetQuestionMark();
            Answer[] answers = CreteMcqChoices();

            short CorrectAnswer;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the Correct Answer ID:");
                flag = short.TryParse(Console.ReadLine(), out CorrectAnswer);
            } while (!flag || CorrectAnswer <= 0 || CorrectAnswer > 3);

            return new MCQ()
            {
                Header = "MCQ",
                Body = QuestionBody,
                Mark = mark,
                Answers = answers,
                CorrectAnswer = CorrectAnswer
            };
        }

        public static Answer[] CreteMcqChoices()
        {
            string choice;
            Answer[] answers = new Answer[3];

            Console.WriteLine("[Choices of the Question]");

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine($"Please Enter Choice Number {i + 1}:");
                    choice = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(choice));

                answers[i] = new Answer(i + 1, choice);

            }

            return answers;

        }
        #endregion

        #region Question
        public static double GetQuestionMark()
        {
            double QuestionMark;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the Question Mark:");
                flag = Double.TryParse(Console.ReadLine(), out QuestionMark);
            } while (!flag || QuestionMark <= 0);

            return QuestionMark;
        }


        public static short GetQuestionType()
        {
            short QuestionType;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter Type of Question (1 for MCQ | 2 for True or False):");
                flag = short.TryParse(Console.ReadLine(), out QuestionType);
            } while (!flag || (QuestionType != 1 && QuestionType != 2));

            return QuestionType; //1 for MCQ, 2 for True or False
        }
        #endregion

        #region True Or False
        public static TrueOrFalse CreateTrueOrFalseQuestion()
        {
            string QuestionBody;
            do
            {
                Console.WriteLine("True or False Question \nPlease Enter Question Body:");
                QuestionBody = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(QuestionBody));

            double mark = GetQuestionMark();
            Answer[] answers =
            {
                new Answer(1,"True"),
                new Answer(2,"False")
            };

            short CorrectAnswer;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the Correct Answer ID: (1 for True | 2 for False)");
                flag = short.TryParse(Console.ReadLine(), out CorrectAnswer);
            } while (!flag || CorrectAnswer <= 0 || CorrectAnswer > 2);

            return new TrueOrFalse()
            {
                Header = "True or False",
                Body = QuestionBody,
                Mark = mark,
                Answers = answers,
                CorrectAnswer = CorrectAnswer
            };
        }
        #endregion

        #region Show Exam
        public static short GetAnswerForMCQ()
        {

            short AnswerID;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter The Answer ID:");
                flag = short.TryParse(Console.ReadLine(), out AnswerID);

            } while (!flag || AnswerID <= 0 || AnswerID > 3); //3

            return AnswerID;
        }

        public static short GetAnswerForTrueOrFalse()
        {

            short AnswerID;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter The Answer ID:");
                flag = short.TryParse(Console.ReadLine(), out AnswerID);

            } while (!flag || AnswerID <= 0 || AnswerID > 2); //2

            return AnswerID;
        }

        public static double GetMark(Question question, Answer answer)
        {

            if (answer.AnswerID == question.CorrectAnswer)
            {
                return question.Mark;
            }
            return 0;
        }
        #endregion

        public static bool WillStartExam() 
        {

            Console.WriteLine("Do you want to start the exam? (Y|N)");
            char StartChoice;
            do
            {
                StartChoice = char.ToUpper(Console.ReadKey().KeyChar);
            } while (StartChoice != 'Y' && StartChoice != 'N');

            if (StartChoice == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
