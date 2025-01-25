﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ : Question
    {

        override public string ToString()
        {
            string output = $"{Header} Question \t {Mark} Marks \n\n{Body}\n\n";

            for (int i = 0; i < 3; i++)
            {
                output += $"{Answers[i].ToString()}\n";
            }

            return output;
        }

    }
}
