using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Exam
    {

        public short Time { get; set; }
        public short NumOfQuestions { get; set; }
        public Subject ExamSubject { get; set; }

        public virtual void ShowExam() {

            Console.WriteLine($"Exam of {ExamSubject.SubjectName}");
            Console.WriteLine($"Time of the Exam: {Time} minutes"); // change to hours and minutes later
            Console.WriteLine($"Number of Questions: {NumOfQuestions}");
        
        }

    }
}
