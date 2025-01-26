using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {

        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public Exam ExamOfSubject { get; set; }

        public void CreateExam()
        {

            short examType = Helper.GetExamType();
            short examTime = Helper.GetExamTime();
            short numberOfQuestions = Helper.GetNumberOfQuestions();

            if (examType == 1)
            {
                ExamOfSubject = new PracticalExam(examTime, numberOfQuestions);
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Question {i + 1} : ");
                    ExamOfSubject.Questions[i] = Helper.CreateMcqQuestion();
                }
            }
            else
            {
                ExamOfSubject = new FinalExam(examTime, numberOfQuestions);
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Question {i + 1} : ");

                    short QuestionType = Helper.GetQuestionType();
                    Console.Clear();
                    if (QuestionType == 1) // MCQ
                    {
                        ExamOfSubject.Questions[i] = Helper.CreateMcqQuestion();
                    }
                    else // True | False
                    {
                        ExamOfSubject.Questions[i] = Helper.CreateTrueOrFalseQuestion();

                    }
                }

            }
            Console.Clear();
            if (Helper.WillStartExam())
            {
                ExamOfSubject.StartExam();
            }
            else
            {
                Console.WriteLine("\nExam Creation Done");
                return;
            }
        }
    }
}
