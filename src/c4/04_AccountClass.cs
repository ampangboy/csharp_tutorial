using System;

public class AccountClass
{
  private decimal balance;
  private readonly string address;
  public string name;


  public AccountClass(string inName, string inAddress, decimal inBalance)
  {
    name = inName;
    address = inAddress;

    if (SetBalance(inBalance) == false)
    {
      throw new Exception("Account construction failed: Balance cannot be less than zero");
    }
  }

  public AccountClass(string inName, string inAddress) : this(inName, inAddress, 0)
  {

  }

  public AccountClass(string inName) : this(inName, "Not Supplied", 0)
  {

  }

  public bool SetBalance(decimal inBalance)
  {
    if (inBalance < 0)
    {
      return false;
    }

    balance = inBalance;

    return true;
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