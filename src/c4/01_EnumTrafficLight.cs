using System;

enum TrafficLight
{
  Red,
  RedAmber,
  Green,
  Amber
}

class EnumTrafficLight
{
  public void Main()
  {
    TrafficLight redLight;

    redLight = TrafficLight.Red;
    Console.WriteLine(redLight);
  }
}