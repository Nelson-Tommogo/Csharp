using System;

namespace Func
{
    public class Functions
    {
        static void greeting()
        {
            Console.WriteLine("We've Learn Something new today");
        }

        static void SemesterGPA()
        {
            int totalMarks = 0;

            Console.WriteLine("Press Enter to Enter Details or any other key to quit");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Enter Marks of Unit{i}");
                int marks = int.Parse(Console.ReadLine());
                totalMarks += marks;
            }

            Double Average = totalMarks / 9.0;
            Double GPA = Average / 2;

            string grade = "";
            if (Average <= 30 && Average > 0)
            {
                grade = "D";
            }
            else if (Average <= 40 && Average >= 31)
            {
                grade = "C";
            }
            else if (Average <= 55 && Average >= 41)
            {
                grade = "B-";
            }
            else if (Average <= 65 && Average >= 56)
            {
                grade = "B";
            }
            else if (Average <= 74 && Average >= 66)
            {
                grade = "B+";
            }
            else if (Average <= 79 && Average >= 75)
            {
                grade = "A-";
            }
            else if (Average <= 99 && Average >= 80)
            {
                grade = "A";
            }
            else
            {
                grade = "Invalid value..Not Allowed";
            }

            Console.WriteLine($"Total Marks: {totalMarks}, Average: {Average}, GPA: {GPA}, grade: {grade}");
        }

        public static void Main()
        {
            Console.WriteLine("This is the Function");
            SemesterGPA();
            greeting();
        }
    }
}
