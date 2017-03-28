

using System;

class BattleshipBuildingGrids
{
  static void Main(string[] args)
  {
    // Create grid variable name
    int[,] grid;
    // Allocate memory for grid
    grid = new int[8, 8];

    // Fill grid with water
    for (int i = 0; i < 8; i++)
    {
      for (int j = 0; j < 8; j++)
      {
        grid[i, j] = 0;
      }
    }

    // Place Ships
    Random rnd;
    rnd = new Random();

    for (int i = 0; i < 5; i++)
    {
      int random_x = rnd.Next(7);
      int random_y = rnd.Next(7);
      grid[random_y, random_x] = 1;
    }

    while (true)
    {
      // Draw Grid
      Console.Clear();
      Console.WriteLine("    0  1  2  3  4  5  6  7 ");
      for (int i = 0; i < 8; i++)
      {
        Console.Write(" " + i + " ");
        for (int j = 0; j < 8; j++)
        {

          if (grid[i, j] == 0) // Open Water
          {
            Console.Write("[0]");
          }
          else if (grid[i, j] == 1) // Has a ship
          {
            Console.Write("[-]");
          }
          else if (grid[i, j] == 2) // Blown up ship
          {
            Console.Write("[*]");
          }
        }
        Console.WriteLine();
      }

      // Get Input
      Console.WriteLine("Enter the coordinates to shoot. Ex: 2,3");
      string input = Console.ReadLine();
      string[] coords = input.Split(',');
      int x;
      int y;
      y = Convert.ToInt32(coords[0]);
      x = Convert.ToInt32(coords[1]);


      // Update Grid
      if (grid[y, x] == 1)
      {
        // hit!
        Console.WriteLine("You hit!");
        grid[y, x] = 2;
      }
      else
      {
        // miss!
        Console.WriteLine("You missed!");
      }
      Console.WriteLine("Press enter to continue");
      Console.ReadLine();
    }

  }
}






