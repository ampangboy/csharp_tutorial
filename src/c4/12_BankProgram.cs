using System;
using System.Collections;

interface IBank
{
  public void StoreAccount(CustomerAccount newAccount);
  public CustomerAccount FindAccount(string name);
}

public class Bank : IBank
{
  private readonly Hashtable BankHashTable;

  public Bank()
  {
    BankHashTable = new Hashtable();
  }

  public void StoreAccount(CustomerAccount newAccount)
  {
    BankHashTable.Add(newAccount.name, newAccount);
  }

  public CustomerAccount FindAccount(string name)
  {
    return BankHashTable[name] as CustomerAccount;
  }
}

class BankProgram
{
  public static void Main()
  {
    IBank ourBank;
    CustomerAccount newAccount;

    ourBank = new DictionaryBank();
    newAccount = new CustomerAccount("Rob", 100);

    ourBank.StoreAccount(newAccount);
    Console.WriteLine("The account added to the bank");

    if (ourBank.FindAccount("Rob Miller") != null)
    {
      Console.WriteLine("Found the account!");
    }

    ourBank.Save
  }
}