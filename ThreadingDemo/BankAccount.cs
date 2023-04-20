namespace ThreadingDemo;

public class BankAccount
{
    private readonly object _accountLock = new();
    private double Balance { get; set; }
    private string Name { get; set; } = "No Name";

    public BankAccount(double balance)
    {
        Balance = balance;
    }

    private double Withdraw(double amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine($"Sorry, {Balance} in account");
            return Balance;
        }

        lock (_accountLock)
        {
            Console.WriteLine($"Removed {amount} from account. Balance is now {Balance - amount}");
            Balance -= amount;
            return Balance;
        }
    }

    public void IssueWithdraw()
    {
        Withdraw(1);
    }
}