class OverloadedConstructor
{
  public static void Main()
  {
    const int MAX_CUST = 100;
    AccountClass[] accounts;

    accounts = new AccountClass[MAX_CUST];
    accounts[0] = new AccountClass("Rob", "Rob's House", 1000000);
    accounts[0] = new AccountClass("Jim", "Jim's House");
    accounts[0] = new AccountClass("Fred");
  }
}