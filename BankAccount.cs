using System.Security.Cryptography.X509Certificates;

public class BankAccount
{
    private int balance;
    private string holder;

    public BankAccount()
    {
        holder="Usuario1";
        balance=1000;
    }

    public void ShowBalance()
    {
        Console.WriteLine("Su balance es de :"+balance);
    }
     
}