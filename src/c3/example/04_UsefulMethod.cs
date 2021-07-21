using System;

internal class UsefulMethod
{
  private static double ReadValue(string prompt, double min, double max)
  {
    double value;
    string valueString;

    do
    {
      Console.WriteLine("{0} between {1} and {2}", prompt, min, max);
      valueString = Console.ReadLine();
      value = double.Parse(valueString);
    } while (value < min || value > max);


    return value;
  }

  private const double MAX_WIDTH = 5.0;
  private const double MIN_WIDTH = 0.5;

  private void Main()
  {
    double windowWidth;

    windowWidth = ReadValue("Enter the width of window", MIN_WIDTH, MAX_WIDTH);

    Console.WriteLine("Width: {0}", windowWidth);
  }
}