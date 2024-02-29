using System;

class Program
{
    static double balance = 1000; // Initial balance

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    Deposit();
                    break;
                case "3":
                    Withdraw();
                    break;
                case "4":
                    Console.WriteLine("Exiting the ATM. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your balance is: ${balance}");
    }

    static void Deposit()
    {
        Console.Write("Enter the amount to deposit: $");
        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance is: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter the amount to withdraw: $");
        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. New balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
    }
}