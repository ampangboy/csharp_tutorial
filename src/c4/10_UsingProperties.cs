using System;

public class StaffMember
{
  private int ageValue;

  public int Age
  {
    set
    {
      if (value > 0)
      {
        ageValue = value;
      }
    }

    get => ageValue;
  }

  public StaffMember(int inAge)
  {
    Age = inAge;
  }
}

public class UsingProperties
{
  public void Main()
  {
    StaffMember staffMember;

    staffMember = new StaffMember(23);
    Console.WriteLine(staffMember.Age);
  }
}