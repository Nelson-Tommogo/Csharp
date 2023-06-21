#include <iostream>
#include <mysql_driver.h>
#include <mysql_connection.h>

using namespace std;

class Subscriber {
public:
    string name;
    string phoneNumber;
    double airtimeAmount;
    int bonusPoints;

    Subscriber(string name, string phoneNumber, double airtimeAmount)
    {
        this->name = name;
        this->phoneNumber = phoneNumber;
        this->airtimeAmount = airtimeAmount;
        this->bonusPoints = computeBonusPoints();
    }

    int computeBonusPoints()
    {
        if (airtimeAmount >= 2000.00)
            return 500;
        else if (airtimeAmount >= 1000.00)
            return 300;
        else if (airtimeAmount >= 500.00)
            return 100;
        else if (airtimeAmount >= 100.00)
            return 50;
        else
            return 0;
    }

    void displayInfo()
    {
        cout << name << " (PHONE NO: " << phoneNumber << "): AWARDED " << bonusPoints << " BONGA POINTS. STAY WITH SAFARICOM. THE BETTER OPTION!" << endl;
    }
};

int main()
{
    sql::mysql::MySQL_Driver *driver;
    sql::Connection *con;

    // Establish connection to the MySQL database
    driver = sql::mysql::get_mysql_driver_instance();
    con = driver->connect("tcp://127.0.0.1:3306", "root", "genius");
    con->setSchema("Airtime");

    // Capture subscriber details
    string name;
    string phoneNumber;
    double airtimeAmount;

    cout << "Enter Subscriber Name: ";
    getline(cin, name);
    cout << "Enter Phone Number: ";
    getline(cin, phoneNumber);
    cout << "Enter Airtime Amount: ";
    cin >> airtimeAmount;

    cin.ignore(); // Ignore the newline character after cin

    // Create a new subscriber
    Subscriber subscriber(name, phoneNumber, airtimeAmount);

    // Save the subscriber details to the database
    sql::Statement *stmt = con->createStatement();
    stmt->execute("INSERT INTO subscribers (name, phone_number, airtime_amount, bonus_points) VALUES ('" + subscriber.name + "', '" + subscriber.phoneNumber + "', " + to_string(subscriber.airtimeAmount) + ", " + to_string(subscriber.bonusPoints) + ")");
    delete stmt;

    // Display subscriber information
    subscriber.displayInfo();

    // Close the connection
    delete con;

    return 0;
}
