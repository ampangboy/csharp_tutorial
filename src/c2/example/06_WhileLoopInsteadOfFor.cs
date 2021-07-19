using System;

internal class WhileLoopInsteadOfForLoop
{
  public void Main()
  {
    int i;
    i = 1;
    while (i < 11)
    {
      Console.WriteLine("Hello mum");
      i = i + 1;
    }
  }
}