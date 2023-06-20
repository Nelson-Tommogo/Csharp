using System;
using System.Collections.Generic;

// Base class: Person
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Derived class: Student
class Student : Person
{
    public int StudentID { get; set; }
    public string GradeLevel { get; set; }

    public virtual void CalculateGrade()
    {
        Console.WriteLine($"grade for {Name}");
    }
}

// Derived class: HighSchoolStudent
class HighSchoolStudent : Student
{
    public override void CalculateGrade()
    {
        Console.WriteLine($"grade for {Name} as a high school student");
        // Perform high school student grade calculation logic
    }
}

// Derived class: CollegeStudent
class CollegeStudent : Student
{
    public override void CalculateGrade()
    {
        Console.WriteLine($"Grade for {Name} as a college student");
        // Perform college student grade calculation logic
    }
}

// Derived class: Teacher
class Teacher : Person
{
    public string Subject { get; set; }
    public int YearsOfExperience { get; set; }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {Subject}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating student objects
        Student highSchoolStudent = new HighSchoolStudent
        {
            Name = "Nelson Tommogo",
            Age = 22,
            StudentID = 20/04172,
            GradeLevel = "4th Year"
        };

        Student collegeStudent = new CollegeStudent
        {
            Name = "Jane Akinyi",
            Age = 20,
            StudentID = 17/98989,
            GradeLevel = "4th Year"
        };

        // Creating teacher object
        Teacher teacher = new Teacher
        {
            Name = "Mr. Jhn",
            Age = 35,
            Subject = "Mathematics",
            YearsOfExperience = 10
        };

        // Polymorphism: Student objects referring to HighSchoolStudent and CollegeStudent objects
        Student student1 = highSchoolStudent;
        Student student2 = collegeStudent;

        // Using object methods and properties
        highSchoolStudent.DisplayInfo();
        highSchoolStudent.CalculateGrade();
        Console.WriteLine();

        collegeStudent.DisplayInfo();
        collegeStudent.CalculateGrade();
        Console.WriteLine();

        // Polymorphism: Invoking methods via Student objects
        student1.DisplayInfo();
        student1.CalculateGrade();
        Console.WriteLine();

        student2.DisplayInfo();
        student2.CalculateGrade();
        Console.WriteLine();

        // Teacher's methods
        teacher.DisplayInfo();
        teacher.Teach();
    }
}
