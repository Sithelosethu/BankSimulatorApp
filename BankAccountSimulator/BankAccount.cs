public class BankAccount
{
    public string AccountHolder { get; private set; }
    public double AccountBalance { get; private set; }
    public int AccountNumber { get; private set; }

    public BankAccount(string accountHolder, int accountNumber, double accountBalance)
    {
        AccountHolder = accountHolder;
        AccountNumber = accountNumber;
        AccountBalance = accountBalance;
    }

    public void Deposit()
    {
        Console.WriteLine("How much do you want to deposit: ");
        double DepositAmount;
        while (!double.TryParse(Console.ReadLine(), out DepositAmount) || DepositAmount <= 0)
        {
            Console.WriteLine("Invalid amount, please enter a positive amount: ");
        }
        AccountBalance += DepositAmount;
        Console.WriteLine($"You have deposited: {DepositAmount:C}. New balance: {AccountBalance:C}");
    }

    public void Withdraw()
    {
        Console.WriteLine("How much do you want to withdraw: ");
        double WithdrawAmount;
        while (!double.TryParse(Console.ReadLine(), out WithdrawAmount) || WithdrawAmount > AccountBalance || WithdrawAmount <= 0)
        {
            Console.WriteLine("Invalid amount, please enter an amount less than or equal to your balance and greater than zero: ");
        }
        AccountBalance -= WithdrawAmount;
        Console.WriteLine($"You have withdrawn: {WithdrawAmount:C}. New balance: {AccountBalance:C}");
    }

    public void Display()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}\nAccount Number: {AccountNumber}\nAccount Balance: {AccountBalance:C}");
    }
}

