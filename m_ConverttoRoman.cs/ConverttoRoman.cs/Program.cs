using System;

  class ConverttoRoman
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a number to be converted: ");
      string input = Console.ReadLine();
      int userInt = Convert.ToInt32(input);

      string result = ConvertToRoman(userInt);
      Console.WriteLine(input + " written as Roman Numerals " + result);
      Console.ReadLine();
    }

    static string ConvertToRoman(int number)
    {
      string roman = "";
      while (number >= 100)
      {
        number = number - 100;
        roman = roman + "C";
      }
      if (number >= 90)
      {
        number = number - 90;
        roman = roman + "XC";
      }
      if (number >= 50)
      {
        number = number - 50;
        roman = roman + "L";
      }
      if (number >= 40)
      {
        number = number - 40;
        roman = roman + "XL";
      }
      while (number >= 10)
      {
        number = number - 10;
        roman = roman + "X";
      }
      if (number >= 9)
      {
        number = number - 9;
        roman = roman + "IX";
      }
      if (number >= 5)
      {
        number = number - 5;
        roman = roman + "V";
      }
      if (number >= 4)
      {
        number = number - 4;
        roman = roman + "IV";
      }
      while (number >= 1)
      {
        number = number - 1;
        roman = roman + "I";
      }
      return roman;
    }
  }
