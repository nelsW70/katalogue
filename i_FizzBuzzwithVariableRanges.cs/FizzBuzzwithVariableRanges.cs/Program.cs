using System;
class FizzBuzzwithVariableRanges
{
  static void Main()
  {
    string inputStart;
    System.Console.WriteLine("Enter a starting whole number for fizzbuzz to buzz from...");
    inputStart = Console.ReadLine();
    int intStart = Convert.ToInt32(inputStart);

    string inputEnd;
    System.Console.WriteLine("Enter a higher whole number for fizzbuzz to buzz to...");
    inputEnd = Console.ReadLine();
    int intEnd = Convert.ToInt32(inputEnd);

    for (int n = intStart; n <= intEnd; n++)
    {
      if (n % 15 == 0)
      {
        Console.WriteLine("FizzBuzz");
      }
      else if (n % 3 == 0)
      {
        Console.WriteLine("Fizz");
      }
      else if (n % 5 == 0)
      {
        Console.WriteLine("Buzz");
      }
      else
      {
        Console.WriteLine(n);
      }
    }
  }
}
