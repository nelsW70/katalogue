
using System;
  class ArraysNumberGuess
  {
    public static void Main(string[] args)
    {
      int[] array = { 5, 4, 9 };
      bool loop = false;
      Console.WriteLine("Guess a number between 1 and 10.");

      while (loop == false)
      {
        string response = Console.ReadLine();
        int guess = Convert.ToInt16(response);

        for (int i = 0; i < array.Length; i++)
        {
          if (array[i] == guess)
          {
            loop = true;
            Console.WriteLine("Nice, " + guess + " is right!");
          }
        }
        if (loop == false)
        {
          Console.WriteLine("Nope. Try again.");
        }
      }
      Console.WriteLine("Thanks for playing.");
      Console.ReadLine();
    }
  }

