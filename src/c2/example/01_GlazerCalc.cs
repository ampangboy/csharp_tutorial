using System;

internal class GlazerCalc
{
  private void calculateWindow()
  {
    // this value is exceeded the byte data type limit hence
    // it will give the compiler error
    // byte exceededValue = 256;
    double width, height, woodLength, glassArea;
    string widthString, heightString;

    widthString = Console.ReadLine();
    width = double.Parse(widthString);

    heightString = Console.ReadLine();
    height = double.Parse(heightString);

    woodLength = 2 * (width + height) * 3.25;

    glassArea = 2 * (width * height);

    Console.WriteLine("The length of the wood is " + woodLength + " feet");
    Console.WriteLine("The area of the glass is " + glassArea + " square metres");
    Console.WriteLine(@"The quick brown fox 
                        jumps
                         over the lazy dog");
  }
}