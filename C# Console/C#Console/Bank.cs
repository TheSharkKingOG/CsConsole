

public class BankAccount
{
    public double balance; //Private: Cant be accessed directly

    public void Deposit(double amount)
    {
        balance += amount;

    }
    public double GetBalance()
    {
        return balance;
    }


}

BankAccount account = new BankAccount();
account.Deposit(100);
Console.WriteLineWriteLine(account.GetBalance());