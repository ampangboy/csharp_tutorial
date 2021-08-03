using System;
using System.Collections.Generic;

class DictionaryBank : IBank
{
  readonly Dictionary<string, CustomerAccount> accountDictionary;

  public DictionaryBank()
  {
    accountDictionary = new Dictionary<string, CustomerAccount>();
  }

  public void StoreAccount(CustomerAccount newAccount)
  {
    if (accountDictionary.ContainsKey(newAccount.name))
    {
      throw new Exception("Name already exists in the bank");
    }

    accountDictionary.Add(newAccount.name, newAccount);
  }

  public CustomerAccount FindAccount(string name)
  {
    if (!accountDictionary.ContainsKey(name))
    {
      return null;
    }

    return accountDictionary[name];
  }
}