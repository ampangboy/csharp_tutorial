using System;

class AccountStructureArray
{
  private static void PrintAccount(AccountStructure a)
  {
    Console.WriteLine("Name: {0}", a.Name);
    Console.WriteLine("State: {0}", a.State);
    Console.WriteLine("Balance: {0}", a.Balance);
  }

  public void Main()
  {
    const int MAX_CUST = 100;
    AccountStructure[] Bank;

    Bank = new AccountStructure[MAX_CUST];
    Bank[0].Name = "Rob";
    Bank[0].State = AccountState.Active;
    Bank[0].Balance = 100000;

    Bank[1].Name = "Jim";
    Bank[1].Balance = 0;
    Bank[1].State = AccountState.Frozen;

    PrintAccount(Bank[0]);
    PrintAccount(Bank[1]);
  }
}