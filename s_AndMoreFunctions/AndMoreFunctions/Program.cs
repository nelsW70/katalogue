using System;

class AndMoreFunctions
{
  static void Main(string[] args)
  {
    WriteToConsole("Hello", 5);
  }

  static void WriteToConsole(string message, int totalTimes)
  {
    for (int i = 0; i < totalTimes; i++)
    {
      Console.WriteLine(message);
    }
  }
}

