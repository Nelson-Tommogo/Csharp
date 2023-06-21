using System;
using MySql.Data.MySqlClient;

class Book
{
    public string Author { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public int BookNumber { get; set; }
    public int NumCopies { get; set; }
}

class Program
{
    static void Main()
    {
        string connectionString = "server=localhost;database=tommogoschooldb;uid=root;pwd=genius;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            InsertBook(connection, "Author 1", 29.99, "Book 1", 1001, 5);
            InsertBook(connection, "Author 2", 19.99, "Book 2", 1002, 3);
            InsertBook(connection, "Author 3", 24.99, "Book 3", 1003, 7);

            Console.WriteLine("Books inserted successfully.");

            // Displaying all books in the database
            DisplayBooks(connection);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    static void InsertBook(MySqlConnection connection, string author, double price, string title, int bookNumber, int numCopies)
    {
        string query = "INSERT INTO books (author, price, title, book_number, num_copies) " +
                       "VALUES (@JohnSmith, @39.99, @C# Programming: From Beginner to Pro, @2001, @10)";

        MySqlCommand command = new MySqlCommand(query, connection);

        command.Parameters.AddWithValue("@Author", author);
        command.Parameters.AddWithValue("@Price", price);
        command.Parameters.AddWithValue("@Title", title);
        command.Parameters.AddWithValue("@BookNumber", bookNumber);
        command.Parameters.AddWithValue("@NumCopies", numCopies);

        command.ExecuteNonQuery();
    }

    static void DisplayBooks(MySqlConnection connection)
    {
        string query = "SELECT * FROM books";

        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            Console.WriteLine("List of books:");
            while (reader.Read())
            {
                Console.WriteLine($"Book Number: {reader.GetInt32("book_number")}");
                Console.WriteLine($"Title: {reader.GetString("title")}");
                Console.WriteLine($"Author: {reader.GetString("author")}");
                Console.WriteLine($"Price: {reader.GetDouble("price")}");
                Console.WriteLine($"Copies available: {reader.GetInt32("num_copies")}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Database Empty....No Book!!!!!");
        }

        reader.Close();
    }
}
