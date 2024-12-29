using System;

namespace BankAccountSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("********** Sithelo Bank Services **********");
            Console.WriteLine("**********          WELCOME      **********");

            // Prompt for user information
            Console.WriteLine("What is your name: ");
            string AccountHolder = Console.ReadLine();

            Console.WriteLine("What is your Account number: ");
            int AccountNumber;
            while (!int.TryParse(Console.ReadLine(), out AccountNumber))
            {
                Console.WriteLine("Invalid input, please enter a valid account number: ");
            }

            Console.WriteLine("What is your Balance: ");
            double AccountBalance;
            while (!double.TryParse(Console.ReadLine(), out AccountBalance) || AccountBalance < 0)
            {
                Console.WriteLine("Invalid balance, please enter a valid balance: ");
            }

            // Initialize the BankAccount object
            BankAccount callMethod = new BankAccount(AccountHolder, AccountNumber, AccountBalance);

            // Display options for the user
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option below: ");
                Console.WriteLine("1. Deposit \n2. Withdraw \n3. Display Balance \n4. Exit");
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input, please enter a valid option:");
                }

                switch (option)
                {
                    case 1:
                        callMethod.Deposit();
                        break;
                    case 2:
                        callMethod.Withdraw();
                        break;
                    case 3:
                        callMethod.Display();
                        break;
                    case 4:
                        Console.WriteLine("Thanks, have a great day.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}