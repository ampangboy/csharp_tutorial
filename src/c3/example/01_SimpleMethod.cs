using System;

internal class SimpleMethod
{
  public void Main()
  {
    doit();
    doit();
  }

  private static void doit()
  {
    Console.WriteLine("Hello");
  }
}