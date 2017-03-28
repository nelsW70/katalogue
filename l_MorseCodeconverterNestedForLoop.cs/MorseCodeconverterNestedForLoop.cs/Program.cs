using System;
  class morseCodeconverterNestedForLoop
  {
    public static void Main(string[] args)
    {
      char[] morseAlph = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
  'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z'};

      string[] morseSymb =  { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
  "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", ".-.",
  "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

      Console.WriteLine("Hello, what is your message?");
      string response = Console.ReadLine().ToLower();

      for (int j = 0; j < response.Length; j++)
      {
        for (int i = 0; i < morseAlph.Length; i++)
        {
          if (response[j] == morseAlph[i])
            Console.Write(morseSymb[i]);
        }
      }
      Console.ReadLine();
    }
  }
