using System;

class AccountClass
{
  private decimal balance;
  private readonly string address;
  private readonly string name;

  public AccountClass(string inName, string inAddress, decimal inBalance)
  {
    name = inName;
    address = inAddress;
    balance = inBalance;
  }

  public AccountClass(string inName, string inAddress) : this(inName, inAddress, 0)
  {

  }

  public AccountClass(string inName) : this(inName, "Not Supplied", 0)
  {

  }

  public bool WithdrawFunds(decimal amount)
  {
    if (balance < amount)
    {
      return false;
    }

    balance -= amount;

    return true;
  }

  public void PayInFunds(decimal amount)
  {
    balance += amount;
  }

  public decimal GetBalance()
  {
    return balance;
  }
}

class ObjectDemo
{
  public void Main()
  {
    AccountClass RobsAccount;

    RobsAccount = new AccountClass("Rob", "USA", 1000);
    RobsAccount.PayInFunds(10);
    Console.WriteLine(RobsAccount.GetBalance());
    if (RobsAccount.WithdrawFunds(5))
    {
      Console.WriteLine("Cash Withdrawn");
    }
    else
    {
      Console.WriteLine("Insufficient Balance");
    }

    Console.WriteLine(RobsAccount.GetBalance());
  }
}