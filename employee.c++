#include <iostream>
#include <mysql_driver.h>
#include <mysql_connection.h>

using namespace std;

class Employee {
private:
    string employeeID;
    string firstName;
    string secondName;
    string surname;
    string gender;
    string dateOfBirth;
    double monthlySalary;

public:
    Employee(string employeeID, string firstName, string secondName, string surname, string gender, string dateOfBirth, double monthlySalary)
    {
        this->employeeID = employeeID;
        this->firstName = firstName;
        this->secondName = secondName;
        this->surname = surname;
        this->gender = gender;
        this->dateOfBirth = dateOfBirth;
        this->monthlySalary = monthlySalary;
    }

    void showEmployee()
    {
        cout << "Employee ID: " << employeeID << endl;
        cout << "First Name: " << firstName << endl;
        cout << "Second Name: " << secondName << endl;
        cout << "Surname: " << surname << endl;
        cout << "Gender: " << gender << endl;
        cout << "Date of Birth: " << dateOfBirth << endl;
        cout << "Monthly Basic Salary: " << monthlySalary << endl;
    }

    friend double computePension(Employee emp);
};

double computePension(Employee emp)
{
    double pension = emp.monthlySalary * 0.05;
    return pension;
}

int main()
{
    sql::mysql::MySQL_Driver *driver;
    sql::Connection *con;

    // Establish connection to the MySQL database
    driver = sql::mysql::get_mysql_driver_instance();
    con = driver->connect("tcp://127.0.0.1:3306", "root", "genius");
    con->setSchema("employee");

    // Capture employee details
    string employeeID;
    string firstName;
    string secondName;
    string surname;
    string gender;
    string dateOfBirth;
    double monthlySalary;

    cout << "Enter Employee ID: ";
    getline(cin, employeeID);
    cout << "Enter First Name: ";
    getline(cin, firstName);
    cout << "Enter Second Name: ";
    getline(cin, secondName);
    cout << "Enter Surname: ";
    getline(cin, surname);
    cout << "Enter Gender: ";
    getline(cin, gender);
    cout << "Enter Date of Birth (dd-mm-yyyy): ";
    getline(cin, dateOfBirth);
    cout << "Enter Monthly Basic Salary: ";
    cin >> monthlySalary;

    cin.ignore(); // Ignore the newline character after cin

    // Create a new employee
    Employee emp(employeeID, firstName, secondName, surname, gender, dateOfBirth, monthlySalary);

    // Save the employee details to the database
    sql::Statement *stmt = con->createStatement();
    stmt->execute("INSERT INTO employees (employee_id, first_name, second_name, surname, gender, date_of_birth, monthly_salary) VALUES ('" + emp.employeeID + "', '" + emp.firstName + "', '" + emp.secondName + "', '" + emp.surname + "', '" + emp.gender + "', '" + emp.dateOfBirth + "', " + to_string(emp.monthlySalary) + ")");
    delete stmt;

    // Display employee information
    emp.showEmployee();

    // Compute and display pension contribution
    double pension = computePension(emp);
    cout << "Pension Contribution: " << pension << endl;

    // Close the connection
    delete con;

    return 0;
}
