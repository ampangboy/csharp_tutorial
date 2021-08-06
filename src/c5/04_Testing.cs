using System;

class Testing
{
  public static void Main()
  {
    int errorCount = 0;
    string reply;
    CustomerAccount a;

    reply = CustomerAccount.ValidateName(null);
    if (reply != "Name parameter null")
    {
      Console.WriteLine("Null name test failed");
      errorCount++;
    }

    reply = CustomerAccount.ValidateName("");
    if (reply != "No text in the name")
    {
      Console.WriteLine("Empty name test failed");
      errorCount++;
    }

    reply = CustomerAccount.ValidateName("      ");
    if (reply != "No text in the name")
    {
      Console.WriteLine("Empty name test failed");
      errorCount++;
    }

    a = new CustomerAccount("Rob", 50);
    a.SetName("Jim");
    if (a.GetName() != "Jim")
    {
      Console.WriteLine("Jim GetName failed");
      errorCount++;
    }

    a.SetName("   Pete   ");
    if (a.GetName() != "Pete")
    {
      Console.WriteLine("Pete GetName failed");
      errorCount++;
    }

    if (errorCount > 0)
    {
      Console.WriteLine("{0} failed test(s) found", errorCount);
      Console.Beep();
    }
  }
}