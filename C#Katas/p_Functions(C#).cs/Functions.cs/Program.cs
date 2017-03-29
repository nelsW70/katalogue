using System;

class Functions
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter a number and we'll multiply it x 10");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(TimesTen(x));
    Console.WriteLine("Tada. #computers. Now go outside and play.");
    Console.ReadLine();
  }

  static int TimesTen(int x)
  {
    return (x * 10);
  }
}
