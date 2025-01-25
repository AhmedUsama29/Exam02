using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Question
    {

        public string Header { get; set; }

        public string Body { get; set; }

        public double Mark { get; set; }

        public Answer[] Answers { get; set; }  //still

        public short CorrectAnswer { get; set; } //still


    }
}
