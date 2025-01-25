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

            int examType = Helper.GetExamType();
            short examTime = Helper.GetExamTime();
            short numberOfQuestions = Helper.GetNumberOfQuestions();

            if (examType == 1)
            {
                ExamOfSubject = new PracticalExam()
                {
                    Time = examTime,
                    NumOfQuestions = numberOfQuestions
                };
            }
            else
            {
                ExamOfSubject = new FinalExam()
                {
                    Time = examTime,
                    NumOfQuestions = numberOfQuestions
                };
            }

            
        }


    }
}
