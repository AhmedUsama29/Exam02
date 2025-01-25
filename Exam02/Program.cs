namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject s01 = new Subject()
            {
                SubjectID = 1,
                SubjectName = "Math",
                ExamOfSubject = new Exam()

            };

            int examType;
            bool flag;

            do
            {
                Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final)");
                flag = int.TryParse(Console.ReadLine(), out examType);
            } while (!flag || (examType != 1 && examType != 2));

        }
    }
}
