using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        protected Exam(short time, short numOfQuestions)
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
            Questions = new Question[numOfQuestions];
        }

        public short Time { get; set; }
        public short NumOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public abstract void ShowExam();

    }
}
