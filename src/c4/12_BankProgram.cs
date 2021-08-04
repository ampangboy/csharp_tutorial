using System;
using System.Collections;
using System.IO;

interface IBank
{
  public void StoreAccount(IAccount newAccount);
  public IAccount FindAccount(string name);
}

public class Bank : IBank
{
  private readonly Hashtable BankHashTable;

  public Bank()
  {
    BankHashTable = new Hashtable();
  }

  public void StoreAccount(IAccount newAccount)
  {
    BankHashTable.Add(newAccount.GetName(), newAccount);
  }

  public IAccount FindAccount(string name)
  {
    return BankHashTable[name] as IAccount;
  }

  public void Save(string filename)
  {
    TextWriter textOut;

    textOut = new StreamWriter(filename);
    textOut.WriteLine(BankHashTable.Count);

    foreach (CustomerAccount account in BankHashTable.Values)
    {
      textOut.WriteLine(account.GetType().Name);
      account.Save(textOut);
    }

    textOut.Close();
  }

  public static Bank Load(string filename)
  {
    TextReader textIn;
    Bank bank;
    IAccount account;
    int count;
    string accountName;

    bank = new Bank();
    textIn = new StreamReader(filename);
    count = int.Parse(textIn.ReadLine());

    for (int i = 0; i < count; i++)
    {
      accountName = textIn.ReadLine();
      account = AcccountFactory.MakeAccount(accountName, textIn);
      bank.StoreAccount(account);
    }

    return bank;
  }
}

class BankProgram
{
  public static void Main()
  {
    Bank ourBank, loadBank;
    CustomerAccount newAccount;
    BabyAccount newBabyAccount;

    ourBank = new Bank();
    newAccount = new CustomerAccount("Rob", 100);
    newBabyAccount = new BabyAccount("Umar", 100, "Quyyum");

    ourBank.StoreAccount(newAccount);
    ourBank.StoreAccount(newBabyAccount);
    Console.WriteLine("The account added to the bank");

    if (ourBank.FindAccount("Rob Miller") != null)
    {
      Console.WriteLine("Found the account!");
    }

    ourBank.Save("Test.txt");

    loadBank = Bank.Load("Test.txt");
    IAccount storedAccount = loadBank.FindAccount("Rob");
    if (storedAccount != null)
    {
      Console.WriteLine("Account found in loaded bank!");
    }
  }
}