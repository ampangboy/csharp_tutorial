using System;

internal class ReturnDemo
{
  private static int sillyReturnPlus(int i)
  {
    i = i + 1;
    Console.WriteLine("i is : {0}", i);
    return i;
  }

  public void Main()
  {
    int res;
    res = sillyReturnPlus(5);
    Console.WriteLine("i is: {0}", res);
  }
}