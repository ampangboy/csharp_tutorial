using System;

internal class MethodWithParameters
{
  private static void silly(int i)
  {
    Console.WriteLine("i is : " + i);
  }

  public void Main()
  {
    silly(101);
  }
}