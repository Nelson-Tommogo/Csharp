using System;

// Base class: Animal
class Animal
{
    public string Species { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

// Derived class: Human, inheriting from Animal
class Human : Animal
{
    public string Name { get; set; }
    public string Gender { get; set; }

    public void Talk()
    {
        Console.WriteLine("Hello, I am a human.");
    }

    public void Work()
    {
        Console.WriteLine("Human is working.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of Animal
        Animal animal = new Animal
        {
            Species = "Lion",
            Age = 5
        };

        // Creating an instance of Human
        Human human = new Human
        {
            Species = "Homo sapiens",
            Age = 25,
            Name = "John",
            Gender = "Male"
        };

        // Calling methods of Animal class
        animal.Eat();
        animal.Sleep();

        // Calling methods of Human class
        human.Eat();
        human.Sleep();
        human.Talk();
        human.Work();
    }
}
