using System;

// Base class representing a bank account
public class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
    }

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
}

// Derived class representing a savings account
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }

    public override void Deposit(decimal amount)
    {
        // Additional logic for savings account deposits (e.g., apply interest)
        base.Deposit(amount);
        Console.WriteLine("Interest applied.");
    }
}

// Derived class representing a checking account
public class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Overdraft Limit: {OverdraftLimit:C}");
    }

    public override void Withdraw(decimal amount)
    {
        // Additional logic for checking account withdrawals (e.g., check overdraft limit)
        if (amount <= Balance + OverdraftLimit)
        {
            base.Withdraw(amount);
            Console.WriteLine("Withdrawal successful.");
        }
        else
        {
            Console.WriteLine("Exceeded overdraft limit");
        }
    }
}

// Usage example
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Object creation - Creating instances of classes
        BankAccount account = new BankAccount(); // Object creation
        account.AccountNumber = "123456";
        account.Balance = 1000;
        account.DisplayInfo();

        SavingsAccount savingsAccount = new SavingsAccount(); // Object creation
        savingsAccount.AccountNumber = "789012";
        savingsAccount.Balance = 5000;
        savingsAccount.InterestRate = 2.5;
        savingsAccount.DisplayInfo();
        savingsAccount.Deposit(100);
        savingsAccount.DisplayInfo();

        CheckingAccount checkingAccount = new CheckingAccount(); // Object creation
        checkingAccount.AccountNumber = "345678";
        checkingAccount.Balance = 2000;
        checkingAccount.OverdraftLimit = 500;
        checkingAccount.DisplayInfo();
        checkingAccount.Withdraw(3000);
        checkingAccount.DisplayInfo();

        Console.WriteLine($"Dear {name}, thank you for using the Banking System.");
    }
}
