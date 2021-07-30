using System;

public class AccountSaveAndLoad
{
  const string FILE_NAME = @"Test.text";

  public static void Main()
  {
    IAccount test = new CustomerAccount("Rob", 1000);

    test.Save(FILE_NAME);

    CustomerAccount loaded = CustomerAccount.Load(FILE_NAME);

    Console.WriteLine(loaded.name);
  }
}