using System;
using MySql.Data.MySqlClient;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNumber { get; set; }
    public double SalePrice { get; set; }

    public void SetVehicle(string make, string model, string engineNumber, double salePrice)
    {
        Make = make;
        Model = model;
        EngineNumber = engineNumber;
        SalePrice = salePrice;
    }

    public double GetProfit()
    {
        double profit = SalePrice * 0.15;
        return profit;
    }
}

class Program
{
    static void Main()
    {
        string connectionString = "server=localhost;database=TommogoVehicle;uid=root;pwd=genius;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            Vehicle vehicle = new Vehicle();

            // Capture the vehicle details
            vehicle.SetVehicle("Nissan", "Sunny", "123456", 20000);

            // Save vehicle details to the database
            SaveVehicle(connection, vehicle);

            // Display the profit
            double profit = vehicle.GetProfit();
            Console.WriteLine($"Profit: {profit}");

            // You can access other properties of the vehicle as well
            Console.WriteLine($"Make: {vehicle.Make}");
            Console.WriteLine($"Model: {vehicle.Model}");
            Console.WriteLine($"Engine Number: {vehicle.EngineNumber}");
            Console.WriteLine($"Sale Price: {vehicle.SalePrice}");
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

    static void SaveVehicle(MySqlConnection connection, Vehicle vehicle)
    {
        string query = "INSERT INTO vehicles (make, model, engine_number, sale_price) " +
                       "VALUES (@Mercedes, @C-Class, @987654, @50000)";

        MySqlCommand command = new MySqlCommand(query, connection);

        command.Parameters.AddWithValue("@Make", vehicle.Make);
        command.Parameters.AddWithValue("@Model", vehicle.Model);
        command.Parameters.AddWithValue("@EngineNumber", vehicle.EngineNumber);
        command.Parameters.AddWithValue("@SalePrice", vehicle.SalePrice);

        command.ExecuteNonQuery();
    }
}
