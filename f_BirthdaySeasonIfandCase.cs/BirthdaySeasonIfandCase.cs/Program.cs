using System;

namespace BirthdaySeasonIfandCase
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What month were you born?");
      string month = Console.ReadLine().ToLower();

      if (month == "december" || month == "january" || month == "february")
      {
        Console.WriteLine("It was so cold");
      }
      else if (month.Contains("march") || month.Contains("april") || month.Contains("may"))
      {
        Console.WriteLine("Oh, you mean pittsburgh's other summer");
      }
      switch (month)
      {
        case "june":
          Console.WriteLine("Summer!");
          break;
        case "july":
          Console.WriteLine("Summer!");
          break;
        case "august":
          Console.WriteLine("summer!");
          break;
        case "september":
        case "october":
        case "november":
          Console.WriteLine("It is the fall time, maybe - or third summer");
          break;
        default:
          Console.WriteLine("How is your spelling?");
          break;
      }
      Console.ReadLine();
    }
  }
}
