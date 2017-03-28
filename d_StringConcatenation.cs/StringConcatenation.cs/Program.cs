using System;

  class StringConcatenation
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Enter a word and we'll add a bird to it!");
      string response = Console.ReadLine();

      Console.WriteLine(AddaBird(response));
      Console.ReadLine();
    }
    static string AddaBird(string x)
    {
      string bird = "-bird!";
      return (x + bird);
    }
  }
