using System;

public class BabyAccount : IAccount
{
  decimal balance = 0;

  public bool WithdrawFund(decimal amount)
  {
    if (amount > 10)
    {
      return false;
    }

    if (balance < amount)
    {
      return false;
    }

    balance -= amount;

    return true;
  }

  public void PayInFund(decimal amount)
  {
    balance += amount;
  }

  public decimal GetBalance()
  {
    return balance;
  }
}

public class UsingComponent
{
  const int MAX_CUSTOMER = 10;

  public static void Main()
  {
    IAccount[] accounts;

    accounts = new IAccount[MAX_CUSTOMER];
    accounts[0] = new CustomerAccount();
    accounts[1] = new BabyAccount();

    accounts[0].PayInFund(20);
    accounts[1].PayInFund(20);

    if (accounts[0].WithdrawFund(20) == true)
    {
      Console.WriteLine("Windrawal Successful");
    }
    else
    {
      Console.WriteLine("Windrawal Unsuccesful");
    }

    if (accounts[1].WithdrawFund(20) == true)
    {
      Console.WriteLine("Windrawal Successful");
    }
    else
    {
      Console.WriteLine("Windrawal Unsuccesful");
    }
  }
}