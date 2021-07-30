class MethodLibraries
{
  public static int ReadInt(string prompt, int min, int max)
  {
    string intString;
    int value;

    while (true)
    {
      intString = ReadString(prompt);

      try
      {
        value = int.Parse(intString);
      }
      catch
      {
        System.Console.WriteLine("Invalid age value");
        continue;
      }

      if (value > min && value < max)
      {
        break;
      }
    }

    return value;
  }

  private static string ReadString(string prompt)
  {
    string value;

    do
    {
      System.Console.WriteLine(prompt);
      value = System.Console.ReadLine();
    } while (value == "");

    return value;
  }

  public void Main()
  {
    string name;
    int age;


    name = ReadString("Enter your name:");
    System.Console.WriteLine("Name : {0}", name);

    age = ReadInt("Enter your age:", 10, 70);
    System.Console.WriteLine("Age : {0}", age);
  }
}