using System;
using System.IO;

public interface IAccount
{
  void WithdrawFund(decimal amount);
  void PayInFund(decimal amount);
  decimal GetBalance();
  string PrintRudeLetter();
  public string GetName();
  public void SetName(string inName);
  void Save(string filename);
  void Save(TextWriter inText);
}

public abstract class Account : IAccount
{
  protected decimal balance = 0;
  public string name;

  public Account(string inName, decimal inBalance)
  {
    name = inName;
    balance = inBalance;
  }

  public Account(TextReader inText)
  {

  }

  public abstract string PrintRudeLetter();

  public string GetName()
  {
    return name;
  }

  public void SetName(string inName)
  {
    string err;

    err = CustomerAccount.ValidateName(inName);

    if (err != "")
    {

      throw new Exception("Name is invalid, " + err);
    }

    inName = inName.Trim();
    name = inName;
  }

  public virtual void WithdrawFund(decimal amount)
  {
    if (balance < amount)
    {
      throw new Exception("Account balance is insufficient");
    }

    balance -= amount;
  }

  public void PayInFund(decimal amount)
  {
    balance += amount;
  }

  public decimal GetBalance()
  {
    return balance;
  }

  public virtual void Save(string filename)
  {
    TextWriter textOut = new StreamWriter(filename);
    textOut.WriteLine(name);
    textOut.WriteLine(balance);
    textOut.Close();
  }

  public virtual void Save(TextWriter textOut)
  {
    textOut.WriteLine(name);
    textOut.WriteLine(balance);
  }
}

public class CustomerAccount : Account
{
  public CustomerAccount(string inName, decimal inBalance) : base(inName, inBalance)
  {

  }

  public CustomerAccount(TextReader inText) : base(inText)
  {
    name = inText.ReadLine();
    balance = decimal.Parse(inText.ReadLine());
  }

  public override string PrintRudeLetter()
  {
    return "You suck";
  }

  public static CustomerAccount Load(string filename)
  {
    CustomerAccount account;
    TextReader textIn;
    string nameText, balanceText;
    decimal inBalance;

    try
    {
      textIn = new StreamReader(filename);
      nameText = textIn.ReadLine();
      balanceText = textIn.ReadLine();
      inBalance = decimal.Parse(balanceText);

      return account = new CustomerAccount(nameText, inBalance);
    }
    catch
    {
      throw new Exception("Failed to load the file. The file probably didn't exist");
    }
  }

  public static CustomerAccount Load(TextReader textIn)
  {
    CustomerAccount account;
    string nameText, balanceText;
    decimal inBalance;

    try
    {
      nameText = textIn.ReadLine();
      balanceText = textIn.ReadLine();
      inBalance = decimal.Parse(balanceText);

      return account = new CustomerAccount(nameText, inBalance);
    }
    catch
    {
      throw new Exception("Failed to load the file. The file probably didn't exist");
    }
  }

  public static string ValidateName(string inName)
  {
    if (inName == null)
    {
      return "Name parameter null";
    }

    inName = inName.Trim();
    if (inName == "")
    {
      return "No text in the name";
    }

    return "";
  }


}
public class SimpleInterface
{
  public void Main()
  {
    CustomerAccount account = new CustomerAccount("Rob", 10000);
    Console.WriteLine(account.GetBalance());
  }
}
