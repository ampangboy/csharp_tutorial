using System;

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
public class Point
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
{
  public int x, y;

  public override bool Equals(object obj)
  {
    Point P = (Point)obj;

    if (x == P.x && y == P.y)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class EqualMethod
{
  public void Main()
  {
    Point spaceship, missile;

    spaceship = new Point
    {
      x = 1,
      y = 2
    };

    missile = new Point
    {
      x = 1,
      y = 2
    };

    if (spaceship.Equals(missile))
    {
      Console.WriteLine("We're at the same location");
    }

  }
}