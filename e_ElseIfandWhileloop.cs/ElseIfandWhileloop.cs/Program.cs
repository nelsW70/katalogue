using System;

class ElseIfandWhileloop
{
  static void Main()
  {
    bool loop = false;

    while (loop == false)
    {

      Console.WriteLine("Enter dog, cat, pig or exit.");
      string response = Console.ReadLine().ToLower();

      if (response == "dog")
      {
        Console.WriteLine("Woof!");
      }
      else if (response == "cat")
      {
        Console.WriteLine("Meow!");
      }
      else if (response == "pig")
      {
        Console.WriteLine("oink oink!");
      }
      else if (response == "exit")
      {
        Console.WriteLine("Bye bye now.");
        loop = true;
      }
      else
      {
        Console.WriteLine("Sorry, didn't get that. Try again. ");
      }
    }
    Console.WriteLine("Thanks for playing!");
    Console.ReadLine();
  }
}