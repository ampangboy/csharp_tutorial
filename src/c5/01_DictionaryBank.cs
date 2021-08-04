using System;
using System.Collections.Generic;

class DictionaryBank : IBank
{
  readonly Dictionary<string, IAccount> accountDictionary;

  public DictionaryBank()
  {
    accountDictionary = new Dictionary<string, IAccount>();
  }

  public void StoreAccount(IAccount newAccount)
  {
    if (accountDictionary.ContainsKey(newAccount.GetName()))
    {
      throw new Exception("Name already exists in the bank");
    }

    accountDictionary.Add(newAccount.GetName(), newAccount);
  }

  public IAccount FindAccount(string name)
  {
    if (!accountDictionary.ContainsKey(name))
    {
      return null;
    }

    return accountDictionary[name];
  }
}