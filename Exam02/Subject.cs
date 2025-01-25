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
                    ExamOfSubject.Questions[i] = Helper.GetMCQDetails();
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
                    if (QuestionType == 1) // MCQ
                    {
                        ExamOfSubject.Questions[i] = Helper.GetMCQDetails();
                    }
                    else // True | False
                    {
                        ExamOfSubject.Questions[i] = Helper.GetTrueFalseDetails();

                    }
                }



            }


        }
    }
}
