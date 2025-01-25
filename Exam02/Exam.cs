using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {

        public short Time { get; set; }
        public short NumOfQuestions { get; set; }

        public abstract void ShowExam();

    }
}
