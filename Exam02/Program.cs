namespace Exam02
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

            int examType;
            bool flag;

            do
            {
                Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final)");
                flag = int.TryParse(Console.ReadLine(), out examType);
            } while (!flag || (examType != 1 && examType != 2));



            switch (examType)
            {
                case 1:
                    s01.ExamOfSubject = new PracticalExam();
                    break;
                case 2:
                    s01.ExamOfSubject = new FinalExam();
                    break;

                default: //unreachable because i validate the input
                    Console.WriteLine("incorrect choice");
                    break;
            }

            short examTime;

            do
            {
                Console.WriteLine("Please enter the time for the exam (from 30 min to 180 min):");
                flag = short.TryParse(Console.ReadLine(), out examTime);
            } while (!flag || (examTime < 30 || examTime > 180));

            short numberOfQuestions;
            do
            {
                Console.WriteLine("Please enter the number of questions:");
                flag = short.TryParse(Console.ReadLine(), out numberOfQuestions);
            } while (!flag || numberOfQuestions <= 0);

            Console.Clear();

            s01.ExamOfSubject.Time = examTime;
            s01.ExamOfSubject.NumOfQuestions = numberOfQuestions;

        }
    }
}
