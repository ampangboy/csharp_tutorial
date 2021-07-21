using System;

class TestAccountClass
{
  public void Main()
  {
    AccountClass test;

    test = new AccountClass("Rob", "Miles", 0);
    test.PayInFunds(50);

    if (test.GetBalance() != 50)
    {
      Console.WriteLine("Pay in fund Failed");
    }
    else
    {
      Console.WriteLine("test passed");
    }
  }
}