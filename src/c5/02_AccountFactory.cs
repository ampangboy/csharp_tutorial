using System.IO;

class AcccountFactory
{
  public static IAccount MakeAccount(string name, TextReader inText)
  {
    switch (name)
    {
      case "CustomerAccount":
        return new CustomerAccount(inText);
      case "BabyAccount":
        return new BabyAccount(inText);
      default:
        return null;
    }

  }
}