using System;

public class Program
{
    public static void Main()
    {
        // Declare variables
        string name, email, password;

        // Prompt the user to enter their name and store it in the name variable
        name = GetUserInput("Please enter your name: ");

        // Prompt the user to enter their email and store it in the email variable
        email = GetUserInput("Please enter your email: ");

        // Prompt the user to enter their password and store it in the password variable
        password = GetUserInput("Please enter your password: ");

        // Print the entered values
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Password: " + password);
    }

    public static string GetUserInput(string prompt)
    {
        // Display the prompt to the user
        Console.Write(prompt);

        // Read the user's input and return it
        return Console.ReadLine();
    }
}
