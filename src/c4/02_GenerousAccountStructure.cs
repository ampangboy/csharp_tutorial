enum AccountState
{
  New,
  Active,
  UnderAudit,
  Frozen,
  Closed
};

struct Account
{
  public AccountState State;
  public string Name;
  public string Address;
  public int AccountNumber;
  public int Balance;
  public int Overdraft;
}

class GenerousAccountStructure
{
  public void Main()
  {
    Account RobsAccount;

    RobsAccount.State = AccountState.Active;
    RobsAccount.Name = null;
    RobsAccount.Address = null;
    RobsAccount.AccountNumber = 0;
    RobsAccount.Balance = 1000000;
    RobsAccount.Overdraft = 0;
  }
}