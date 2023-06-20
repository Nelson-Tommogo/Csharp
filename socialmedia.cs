using System;
using System.Collections.Generic;

// Base class representing a user
public class User
{
    public string Username { get; set; }

    public virtual void DisplayProfile()
    {
        Console.WriteLine($"Username: {Username}");
    }
}

// Derived class representing a regular user
public class RegularUser : User
{
    public List<string> Posts { get; set; }

    public override void DisplayProfile()
    {
        base.DisplayProfile();
        Console.WriteLine("Recent Posts:");
        foreach (string post in Posts)
        {
            Console.WriteLine(post);
        }
    }
}

// Derived class representing an influencer user
public class InfluencerUser : User
{
    public int Followers { get; set; }

    public override void DisplayProfile()
    {
        base.DisplayProfile();
        Console.WriteLine($"Followers: {Followers}");
    }
}

// Usage example
class Program
{
    static void Main(string[] args)
    {
        // Object creation - Creating instances of classes
        RegularUser regularUser = new RegularUser();
        regularUser.Username = "JohnDoe";
        regularUser.Posts = new List<string> { "Hey!", "I love coding!" };
        regularUser.DisplayProfile();

        InfluencerUser influencerUser = new InfluencerUser();
        influencerUser.Username = "CommonGenius";
        influencerUser.Followers = 10000;
        influencerUser.DisplayProfile();
    }
}
