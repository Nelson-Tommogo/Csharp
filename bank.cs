using System;

// Base class representing a bank account
public class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C} into Account {AccountNumber}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from Account {AccountNumber}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public virtual void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
    }
}

// Derived class representing a savings account
public class SavingsAccount : BankAccount
{
    public override void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance (Savings): {Balance:C}");
    }
}

// Derived class representing a checking account
public class CheckingAccount : BankAccount
{
    public override void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance (Checking): {Balance:C}");
    }
}

// Usage example
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter your balance: ");
        decimal balance = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter your interest rate (for savings account): ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your overdraft limit (for checking account): ");
        decimal overdraftLimit = Convert.ToDecimal(Console.ReadLine());

        // Object creation - Creating instances of classes
        BankAccount account = new BankAccount();
        account.AccountNumber = accountNumber;
        account.Balance = balance;

        SavingsAccount savingsAccount = new SavingsAccount();
        savingsAccount.AccountNumber = accountNumber;
        savingsAccount.Balance = balance;

        CheckingAccount checkingAccount = new CheckingAccount();
        checkingAccount.AccountNumber = accountNumber;
        checkingAccount.Balance = balance;

        // Perform deposit and withdrawal
        Console.Write("Enter the amount to deposit: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(depositAmount);

        Console.Write("Enter the amount to withdraw: ");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(withdrawalAmount);

        // Calculate and display balance
        Console.WriteLine("\nAccount Balances:");
        Console.WriteLine("=================");
        Console.WriteLine($"Name: {name}");
        account.DisplayBalance();
        savingsAccount.DisplayBalance();
        checkingAccount.DisplayBalance();

        Console.WriteLine($"Dear {name}, thank you for using the Banking System.");
    }
}
