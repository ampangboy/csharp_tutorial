using System;

public delegate decimal CalculateFee(decimal balance);

public class UsingDelegate
{
  public static decimal RipOffFee(decimal balance)
  {
    if (balance < 0)
    {
      return 100;
    }
    else
    {
      return 1;
    }
  }

  public static decimal FriendlyFee(decimal balance)
  {
    if (balance < 0)
    {
      return 10;
    }
    else
    {
      return 1;
    }
  }

  public void Main()
  {
    decimal fee;
    CalculateFee calc;

    Console.WriteLine("Using Rip Off Fee method");

    calc = new CalculateFee(RipOffFee);
    fee = calc(-1);

    Console.WriteLine("Fee is {0}", fee);

    Console.WriteLine("Using Friendly Fee method");

    calc = new CalculateFee(FriendlyFee);
    fee = calc(-1);

    Console.WriteLine("Fee is {0}", fee);
  }
}