using System;
using System.IO;

class FileWriteReadDemo
{
  const string filename = "test.txt";

  public void Main()
  {
    StreamWriter writer;
    StreamReader reader;
    string line;

    writer = new StreamWriter(filename);
    writer.WriteLine("hello world");
    writer.Close();

    reader = new StreamReader(filename);
    while (reader.EndOfStream == false)
    {
      line = reader.ReadLine();
      Console.WriteLine(line);
    }
    reader.Close();
  }
}