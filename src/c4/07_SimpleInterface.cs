using System;

public interface IAccount
{
  bool WithdrawFund(decimal amount);
  void PayInFund(decimal amount);
  decimal GetBalance();
}

public class CustomerAccount : IAccount
{
  private decimal balance = 0;

  public bool WithdrawFund(decimal amount)
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

public class SimpleInterface
{
  public static void Main()
  {
    IAccount account = new CustomerAccount();
    Console.WriteLine(account.GetBalance());
  }
}
