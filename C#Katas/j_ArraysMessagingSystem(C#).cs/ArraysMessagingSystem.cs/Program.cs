using System;

  class ArraysMessagingSystem
  {
    static void Main(string[] args)
    {

      string[] message = new string[5];

      int i = 0;
      bool stop = false;

      while (stop == false)
      {
        Console.WriteLine("Would you like to (s)tore a message,(r)etrieve a message or e(x)it?");
        string response = Console.ReadLine().ToLower();

        if (response == "s")
        {
          // Saving a message
          Console.WriteLine("What is your message?");
          message[i] = Console.ReadLine();
          Console.WriteLine("Saved! Your message ID is " + i);
          i++;
        }
        else if (response == "r")
        {
          // Retrieving a message
          Console.WriteLine("What is your message id?");
          string message_id = Console.ReadLine();
          int message_id_int = Convert.ToInt32(message_id);
          Console.WriteLine("The message is: " + message[message_id_int]);
        }
        else if (response == "x")
        {
          stop = true;
          Console.WriteLine("Bye bye now");
        }
        else
        {
          // Typed anything else
          Console.WriteLine("I didn't understand what you typed.");
        }
      }
      Console.ReadLine();
    }
  }

