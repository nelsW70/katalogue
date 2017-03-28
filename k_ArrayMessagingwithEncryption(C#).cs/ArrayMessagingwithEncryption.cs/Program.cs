using System;

  class ArrayMessagingwithEncryption
  {
    static void Main(string[] args)
    {

      string[] messages = new string[10];
      int x = 0;

      bool something = true;
      while (something == true)
      {
        // Show the menu option
        Console.WriteLine("\nWhat do you wish to do?");
        Console.WriteLine("S) Save a message \nR) Retrieve a message");
        Console.WriteLine("L) List back end data \nQ) Quit");


        // Get the option selected
        string menu_choice = Console.ReadLine().ToUpper();

        switch (menu_choice)
        {
          case "S":
            Console.WriteLine("\nWhat is your message?");
            // get unencrypted
            string unencrypted = Console.ReadLine();
            // encrypt it
            string encrypted = "";// something!

            for (int j = 0; j < unencrypted.Length; j++)
            {
              encrypted = encrypted + (char)(unencrypted[j] + 5);
            }

            // save it to message store
            messages[x] = encrypted;
            Console.WriteLine("\nYour message ID is: " + x);
            x = x + 1;
            // x++;
            // x += 1;
            break;
          case "R":
            Console.WriteLine("\nWhat is the message id you wish to retrieve?");
            int message_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your message is:" + " ");
            string user_message = messages[message_id];
            for (int i = 0; i < user_message.Length; i++)
            {
              Console.Write((char)(user_message[i] - 5));
            }
            break;
          case "L":
            for (int i = 0; i < messages.Length; i++)
            {
              Console.WriteLine(messages[i]);
            }
            break;
          case "Q":
            Console.WriteLine("\nThanks for using my messaging system.");
            something = false;
            break;
          default:
            Console.WriteLine("\nPlease choose a correct option!");
            break;
        }
      }
      Console.ReadLine();
    }
  }
