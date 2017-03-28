using System;

class CaseSwitch
{
  public static void Main(string[] args)
  {
    bool shouldIloop = true;
    while (shouldIloop == true)
    {
      Console.WriteLine("What month were you born in?");
      string Input;
      Input = Console.ReadLine().ToLower();
      switch (Input)
      {
        case "september":
        case "october":
        case "november":
          Console.WriteLine("You were born in the Fall");
          break;
        case "december":
        case "january":
        case "februrary":
          Console.WriteLine("You were born in the Winter");
          break;
        case "march":
        case "april":
        case "may":
          Console.WriteLine("You were born in the Spring");
          break;
        case "june":
        case "july":
        case "august":
          Console.WriteLine("You were born in the Spring");
          break;
        default:
          Console.WriteLine("Please check your spelling");
          break;
      }
      Console.WriteLine("Would you Like to do this again? Enter yes or no.");
      if (Console.ReadLine() == "no")
      {
        shouldIloop = false;
      }
      Console.Clear();
    }
  }
}