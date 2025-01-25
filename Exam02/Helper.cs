using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal static class Helper
    {
        public static int GetExamType()
        {
            int examType;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final)");
                flag = int.TryParse(Console.ReadLine(), out examType);
            } while (!flag || (examType != 1 && examType != 2));
            return examType;
        }

        public static short GetExamTime()
        {
            short examTime;
            bool flag;
            do
            {
                Console.WriteLine("Please enter the time for the exam (from 30 min to 180 min):");
                flag = short.TryParse(Console.ReadLine(), out examTime);
            } while (!flag || (examTime < 30 || examTime > 180));
            return examTime;
        }

        public static short GetNumberOfQuestions()
        {
            short numberOfQuestions;
            bool flag;
            do
            {
                Console.WriteLine("Please enter the number of questions:");
                flag = short.TryParse(Console.ReadLine(), out numberOfQuestions);
            } while (!flag || numberOfQuestions <= 0);
            return numberOfQuestions;
        }
    }
}
