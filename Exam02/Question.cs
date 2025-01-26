using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Question : ICloneable         //Deep Copy if needed
    {

        public string Header { get; set; }

        public string Body { get; set; }

        public double Mark { get; set; }

        public Answer[] Answers { get; set; }

        public short CorrectAnswer { get; set; }

        public abstract object Clone();
           
        
    }
}
