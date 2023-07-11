#include <iostream>
#include <string>

class Subscriber {
private:
    std::string name;
    std::string phoneNumber;
    double airtimeAmount;

public:
    Subscriber(const std::string& name, const std::string& phoneNumber, double airtimeAmount)
        : name(name), phoneNumber(phoneNumber), airtimeAmount(airtimeAmount) {}

    int compute_bonuspoints() const {
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

    void display_info() const {
        std::cout << "Subscriber Name: " << name << std::endl;
        std::cout << "Phone Number: " << phoneNumber << std::endl;
        std::cout << "Airtime Amount: Ksh " << airtimeAmount << std::endl;
        std::cout << "Bonus Points: " << compute_bonuspoints() << std::endl;
    }
};

int main() {
    std::string name, phoneNumber;
    double airtimeAmount;

    std::cout << "Enter Subscriber Name: ";
    std::getline(std::cin, name);

    std::cout << "Enter Phone Number: ";
    std::getline(std::cin, phoneNumber);

    std::cout << "Enter Airtime Amount (in Ksh): ";
    std::cin >> airtimeAmount;

    Subscriber subscriber(name, phoneNumber, airtimeAmount);
    subscriber.display_info();

    return 0;
}
