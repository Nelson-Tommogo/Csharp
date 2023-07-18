using System;
namespace Func{
public class Functions{
    static void greeting(){
        Console.WriteLine("Let's Learn Something new today");
    }
    static void SemesterGPA(){
        int unit1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit1");
        int unit2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit2");
        int unit3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit3");
        int unit3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit4");
        int unit4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit5");
        int unit5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit6");
        int Unit6 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit7");
        int unit7 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks of Unit8");
        int unit8 = int.Parse(Console.ReadLine());
    }
    public static void Main(){
        Console.WriteLine("This is the Function");
        greeting();
        SemesterGPA();
    }    
}}