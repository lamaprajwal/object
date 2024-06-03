public class BankAccount
{
    private double balance;  // Encapsulated data (private member)

    public string AccountNumber { get; set; }  // Public property for account number

    // Public setter with validation (optional for encapsulation)
    public double Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be negative.");
            }
            balance = value;
        }
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("Deposit amount cannot be negative.");
        }
        Balance += amount;  // Access private balance through public property
        Console.WriteLine($"Deposited: ${amount}. New balance: ${Balance}");
    }

    public bool Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("Withdrawal amount cannot be negative.");
        }
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrew: ${amount}. New balance: ${Balance}");
        return true;
    }
}

// Top-level statements using encapsulation