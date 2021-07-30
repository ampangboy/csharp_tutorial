using System.Collections.Generic;

class DictionaryBank : IBank
{
  readonly Dictionary<string, AccountClass> accountDictionary;

  public DictionaryBank()
  {
    accountDictionary = new Dictionary<string, AccountClass>();
  }

  public bool StoreAccount(AccountClass newAccount)
  {
    if (accountDictionary.ContainsKey(newAccount.name))
    {
      return false;
    }

    accountDictionary.Add(newAccount.name, newAccount);

    return true;
  }
  public AccountClass FindAccount(string name)
  {
    if (!accountDictionary.ContainsKey(name))
    {
      return null;
    }

    return accountDictionary[name];
  }
}