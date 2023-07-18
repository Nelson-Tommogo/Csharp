using System;
namespace Func{
public class Functions{
    static void greeting(){
        Console.WriteLine("Let's Learn Something new today");
    }
    static void SemesterGPA(){
        Console.WriteLine("Press 1 to Enter Details and  Enter to quit");

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
    }
    public static void Main(){
        Console.WriteLine("This is the Function");
        SemesterGPA();
        greeting();
    }    
}}