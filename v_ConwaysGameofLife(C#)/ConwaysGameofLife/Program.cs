
using System;
using System.Threading;

class ConwaysGameofLife
{
  public static void Main(string[] args)
  {
    //Declare and populate grid
    Console.WriteLine("What size do you want your grid to be?");
    int s = Convert.ToInt32(Console.ReadLine());
    int b = s + 1; // border
    int total = 0;
    int[,] grid = new int[b, b];
    for (int i = 1; i < s; i++)
    {
      for (int j = 1; j < s; j++)
      {
        grid[i, j] = 0;
      }
    }

    //random coordinates
    Random rnd = new Random();

    for (int i = 0; i < 150; i++)
    {
      int random_x = rnd.Next(1, b - 1);
      int random_y = rnd.Next(1, b - 1);
      grid[random_y, random_x] = 1;
    }

    //starter coordinates
    grid[5, 5] = 1;
    grid[5, 6] = 1;
    grid[5, 7] = 1;
    grid[5, 8] = 1;
    grid[6, 8] = 1;
    grid[6, 9] = 1;

    //Generation loop
    int generation_counter = 0;

    //makes copy of grid[] named nextGen.
    int[,] nextGen = grid.Clone() as int[,];

    while (true)
    {
      generation_counter++;
      Console.Clear();

      //clones grid[] with nextGen values
      grid = nextGen.Clone() as int[,];

      //Display grid
      for (int i = 1; i < s; i++)
      {
        for (int j = 1; j < s; j++)
        {
          if (grid[i, j] == 1)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ResetColor();
          }
          else { Console.Write("0"); }
        }
        Console.WriteLine();
      }
      Console.WriteLine($"Generation Counter: {generation_counter}");

      for (int i = 1; i < s; i++)
      {
        for (int j = 1; j < s; j++)
        {
          total = grid[i - 1, j] + grid[i + 1, j] + grid[i, j - 1]
              + grid[i, j + 1] + grid[i + 1, j + 1]
              + grid[i - 1, j - 1] + grid[i - 1, j + 1]
              + grid[i + 1, j - 1];
          if (grid[i, j] == 1) // 1 means alive
          {
            if (total == 3 || total == 2)
            {
              nextGen[i, j] = 1;
            }
            else
            {
              nextGen[i, j] = 0;
            }
          }
          if (grid[i, j] == 0) // if dead
          {
            if (total == 3) // if dead and total neighbors = 3, cell becomes alive.
            {
              nextGen[i, j] = 1;
            }
          }
        }
      }
      //Console.ReadLine();
      //System.Threading.Thread.Sleep(100);
      Thread.Sleep(100);
    }
  }
}
