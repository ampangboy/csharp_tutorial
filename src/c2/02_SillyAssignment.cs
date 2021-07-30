using System;

internal class SillyAssignment
{
  private void Main()
  {
    // int i;
    // i = (int)123456781234567890.999; since this over the int limit
    // the compiler will throw error
    int first, second, third;

    first = 1;
    second = 2;
    third = second + first;

    Console.WriteLine(first + second + third);
  }
}