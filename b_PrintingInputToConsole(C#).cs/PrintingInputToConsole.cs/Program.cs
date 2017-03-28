using System;
class PrintingInputToConsole
{
	static void Main()
	{
		Console.WriteLine("What's your name?");
		string name = Console.ReadLine();

		Console.WriteLine("Hello " + name + ".");
		Console.ReadLine();
	}
}

