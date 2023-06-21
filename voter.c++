#include <iostream>
#include <mysql_driver.h>
#include <mysql_connection.h>

using namespace std;

class Voter {
public:
    string voterCardID;
    string nationalID;
    string firstName;
    string middleName;
    string surname;
    string pollingStation;
    string dateOfBirth;
    string gender;

    Voter() {}

    Voter(string voterCardID, string nationalID, string firstName, string middleName, string surname, string pollingStation, string dateOfBirth, string gender)
    {
        this->voterCardID = voterCardID;
        this->nationalID = nationalID;
        this->firstName = firstName;
        this->middleName = middleName;
        this->surname = surname;
        this->pollingStation = pollingStation;
        this->dateOfBirth = dateOfBirth;
        this->gender = gender;
    }

    void displayDetails()
    {
        cout << "Voter Card ID: " << voterCardID << endl;
        cout << "National ID: " << nationalID << endl;
        cout << "First Name: " << firstName << endl;
        cout << "Middle Name: " << middleName << endl;
        cout << "Surname: " << surname << endl;
        cout << "Polling Station: " << pollingStation << endl;
        cout << "Date of Birth: " << dateOfBirth << endl;
        cout << "Gender: " << gender << endl;
    }
};

int main() {
    sql::mysql::MySQL_Driver *driver;
    sql::Connection *con;

    // Establish connection to the MySQL database
    driver = sql::mysql::get_mysql_driver_instance();
    con = driver->connect("tcp://127.0.0.1:3306", "your_username", "your_password");
    con->setSchema("your_database_name");

    // Add a new voter
    Voter newVoter("V12345", "1234567890", "John", "Doe", "Smith", "Polling Station A", "01-01-1990", "Male");

    // Save the voter details to the database
    sql::Statement *stmt = con->createStatement();
    stmt->execute("INSERT INTO voters (voter_card_id, national_id, first_name, middle_name, surname, polling_station, date_of_birth, gender) VALUES ('" + newVoter.voterCardID + "', '" + newVoter.nationalID + "', '" + newVoter.firstName + "', '" + newVoter.middleName + "', '" + newVoter.surname + "', '" + newVoter.pollingStation + "', '" + newVoter.dateOfBirth + "', '" + newVoter.gender + "')");
    delete stmt;

    // Display the voter details
    stmt = con->createStatement();
    sql::ResultSet *res = stmt->executeQuery("SELECT * FROM voters WHERE voter_card_id = '" + newVoter.voterCardID + "'");
    if (res->next()) {
        Voter retrievedVoter(
            res->getString("voter_card_id"),
            res->getString("national_id"),
            res->getString("first_name"),
            res->getString("middle_name"),
            res->getString("surname"),
            res->getString("polling_station"),
            res->getString("date_of_birth"),
            res->getString("gender")
        );
        retrievedVoter.displayDetails();
    }
    delete res;
    delete stmt;

    // Close the connection
    delete con;

    return 0;
}
