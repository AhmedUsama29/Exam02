﻿namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject s01 = new Subject()
            {
                SubjectID = 1,
                SubjectName = "Data Structure & Algorithms",

            };

            s01.CreateExam();
            Console.Clear();

            //s01.ExamOfSubject.ShowExam();

            //foreach (Question Question in s01.ExamOfSubject.Questions)
            //{
            //    Console.WriteLine(Question);
            //}


        }
    }
}
