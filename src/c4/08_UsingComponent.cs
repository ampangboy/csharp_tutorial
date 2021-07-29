using System;

public sealed class BabyAccount : Account
{

  public override bool WithdrawFund(decimal amount)
  {
    if (amount > 10)
    {
      return false;
    }

    return base.WithdrawFund(amount);
  }

  public override string PrintRudeLetter()
  {
    return "Your parent suck";
  }
}

public class UsingComponent
{
  const int MAX_CUSTOMER = 10;

  public void Main()
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

    Console.WriteLine(accounts[1].PrintRudeLetter());
  }
}