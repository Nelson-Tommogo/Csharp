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
            Console.WriteLine("Press Enter to Enter Details or any other key to quit");

            int unit1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit1");

            int unit2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit2");

            int unit3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit3");

            int Unit4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit4");

            int Unit5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit5");

            int Unit6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit6");

            int unit7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit7");

            int Unit8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit8");

            
            int unit9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Unit9");


            Double total = unit1 + unit2 + unit3 + Unit4 + Unit5 + Unit6 + unit7 + Unit8 + unit9;
            Double Average = total / 9;
            Double GPA =Average/2;

            string grade = "";
            if(Average <= 30 && Average >0){
                Console.WriteLine("D");
            }
            else if(Average<=40 && Average>= 31){
            Console.WriteLine("C");
            }
             else if(Average<=55 && Average>= 41){
            Console.WriteLine("B-");
            }
             else if(Average<=65 && Average>= 56){
            Console.WriteLine("B");
            }
             else if(Average<=74 && Average>= 66){
            Console.WriteLine("B+");
            }
             else if(Average<=79 && Average>= 75){
            Console.WriteLine("A-");
            }
             else if(Average<=99 && Average>= 80){
            Console.WriteLine("A");
            }
            else
            Console.WriteLine("Invalid value..Not Allowed");

            Console.WriteLine($"Total Marks: {total}, Average: {Average}, GPA: {GPA}, grade:{grade}");
        }

        public static void Main()
        {
            Console.WriteLine("This is the Function");
            SemesterGPA();
            greeting();
        }
    }
}
