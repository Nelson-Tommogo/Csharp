using System;

// Base class representing a book
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    }
}

// Derived class representing a novel
public class Novel : Book
{
    public string Genre { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Genre: {Genre}");
    }
}

// Derived class representing a textbook
public class Textbook : Book
{
    public string Subject { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Subject: {Subject}");
    }
}

// Usage example
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Object creation - Creating instances of classes
        Book book = new Book(); // Object creation
        book.Title = "Generic Book";
        book.Author = "Unknown";
        book.Year = 2023;
        book.DisplayInfo();

        Novel novel = new Novel(); // Object creation
        novel.Title = "Pride and Prejudice";
        novel.Author = "Jane Austen";
        novel.Year = 1813;
        novel.Genre = "Romance";
        novel.DisplayInfo();

        Textbook textbook = new Textbook(); // Object creation
        textbook.Title = "Introduction to Computer Science";
        textbook.Author = "John Smith";
        textbook.Year = 2021;
        textbook.Subject = "Computer Science";
        textbook.DisplayInfo();

        Console.WriteLine($"Dear {name}, thank you for using the Library Management System.");
    }
}
