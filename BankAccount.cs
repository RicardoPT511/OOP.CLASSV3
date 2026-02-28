using System;

public class BankAccount
{
    private int balance;
    private string holder;

    public BankAccount()
    {
        holder = "Usuario1";
        balance = 1000;
    }

    public void ShowBalance()
    {
        Console.WriteLine("El saldo es de " + balance);
    }

    public void Deposit(int amount)
    {
        balance += amount;
        Console.WriteLine("Se depositaron " + amount);
    }

    public void Withdraw(int amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("No es posible retirar " + amount + 
            " ya que es mayor a los " + balance + " que se tienen");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Se retiraron " + amount);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.ShowBalance();     
        account.Deposit(500);       
        account.Withdraw(2000);     
        account.Withdraw(500);      
        account.ShowBalance();      
    }
}