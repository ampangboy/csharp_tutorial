using System;
using System.IO;

public class BabyAccount : CustomerAccount
{
  readonly string parentName;

  public BabyAccount(string inName, decimal inBalance, string inParentName) : base(inName, inBalance)
  {
    parentName = inParentName;
  }

  public BabyAccount(TextReader inText) : base(inText)
  {
    parentName = inText.ReadLine();
  }


  public override void WithdrawFund(decimal amount)
  {
    if (amount > 10)
    {
      throw new Exception("Max amount allowed to be drawn is up to 10 dollar!");
    }

    base.WithdrawFund(amount);
  }

  public override string PrintRudeLetter()
  {
    return "Your parent suck";
  }

  public override void Save(TextWriter textOut)
  {
    base.Save(textOut);
    textOut.WriteLine(parentName);
  }
}

public class UsingComponent
{
  const int MAX_CUSTOMER = 10;

  public void Main()
  {
    IAccount[] accounts;

    accounts = new IAccount[MAX_CUSTOMER];
    accounts[0] = new CustomerAccount("Baby Umar", 0);
    accounts[1] = new BabyAccount("Umar", 10, "Quyyum");

    accounts[0].PayInFund(20);
    accounts[1].PayInFund(20);

    accounts[0].WithdrawFund(20);
    Console.WriteLine("Windrawal Successful");

    accounts[1].WithdrawFund(20);
    Console.WriteLine("Windrawal Successful");

    Console.WriteLine(accounts[1].PrintRudeLetter());
  }
}