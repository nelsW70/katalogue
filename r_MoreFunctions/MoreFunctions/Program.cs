using System;

class MoreFunctions
{
  static void Main(string[] args)
  {
    WriteToConsole("Hello there!");
    WriteToConsole("I will write whatever you tell me!");
  }

  static void WriteToConsole(string message)
  {
    Console.WriteLine(message);
  }
}
