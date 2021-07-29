using System;

public interface IAccount
{
  bool WithdrawFund(decimal amount);
  void PayInFund(decimal amount);
  decimal GetBalance();
  string PrintRudeLetter();
}

public abstract class Account : IAccount
{
  private decimal balance = 0;

  public abstract string PrintRudeLetter();

  public virtual bool WithdrawFund(decimal amount)
  {
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

public class CustomerAccount : Account
{
  public override string PrintRudeLetter()
  {
    return "You suck";
  }
}

public class SimpleInterface
{
  public void Main()
  {
    CustomerAccount account = new CustomerAccount();
    Console.WriteLine(account.GetBalance());
  }
}
