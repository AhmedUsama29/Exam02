﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Question
    {

        public string Header { get; set; }

        public string Body { get; set; }

        public double Mark { get; set; }

        public Answer[] Answers { get; set; }  //still

        public string CorrectAnswer { get; set; } //still


    }
}
