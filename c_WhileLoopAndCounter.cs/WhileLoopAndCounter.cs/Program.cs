using System;

class WhileLoopAndCounter
{
  static void Main()
  {
    // Continue in while-loop until index is equal to 10.
    int counter = 0;
    while (counter <= 10)
    {
      Console.Write("While statement ");
      // Write the index to the screen.
      Console.WriteLine(counter);
      // Increment the variable.
      counter++;
    }
    Console.ReadLine();
  }
}