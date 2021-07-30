using System;
using System.Collections;

interface IBank
{
  public bool StoreAccount(AccountClass newAccount);
  public AccountClass FindAccount(string name);
}

public class Bank : IBank
{
  private readonly Hashtable BankHashTable;

  public Bank()
  {
    BankHashTable = new Hashtable();
  }

  public bool StoreAccount(AccountClass newAccount)
  {
    BankHashTable.Add(newAccount.name, newAccount);
    return true;
  }

  public AccountClass FindAccount(string name)
  {
    return BankHashTable[name] as AccountClass;
  }
}

class BankProgram
{
  public static void Main()
  {
    IBank ourBank;
    AccountClass newAccount;

    ourBank = new Bank();
    newAccount = new AccountClass("Rob", "Rob's House", 100);

    if (ourBank.StoreAccount(newAccount) == true)
    {
      Console.WriteLine("The account added to the bank");
    }

    if (ourBank.FindAccount("Rob") != null)
    {
      Console.WriteLine("Found the account!");
    }
  }
}