

using System;

class JohnsGameofLife
{
  static void Main(string[] args)
  {
    int gridsize = 20;

    // create our grid
    int[,] grid = new int[gridsize, gridsize];

    // Add a known shape
    grid[5, 5] = 1;
    grid[5, 6] = 1;
    grid[5, 7] = 1;

    while (true)
    {
      // create a new temporary grid
      int[,] new_grid = new int[gridsize, gridsize];

      // do some work to temp grid
      for (int i = 0; i < grid.GetLength(0); i++)
      {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
          // Follow the rules of Game of Life
          // If cell is alive and has < 2 or > 3 neighbors, kill it
          // If a cell is alive and has 2 or 3 neighbors, leave it alive
          // If a cell is dead and has 3 neighbors, ressurect it like Lazerus
          // Otherwise, if a cell is dead, it stays dead

          // First, find out how many neighbors are alive

          int neighbors = 0;
          // left first
          if (j > 0)
          {
            if (grid[i, j - 1] == 1)
            {
              neighbors = neighbors + 1;
            }
          }
          if (i > 0 && j > 0)
          {
            if (grid[i - 1, j - 1] == 1)
            {
              neighbors++;
            }
          }
          if (i > 0)
          {
            if (grid[i - 1, j] == 1)
            {
              neighbors += 1;
            }
          }
          if (i > 0 && j < gridsize - 1)
          {
            if (grid[i - 1, j + 1] == 1)
            {
              neighbors = neighbors + 1;
            }
          }
          if (j < gridsize - 1)
          {
            if (grid[i, j + 1] == 1)
            {
              neighbors++;
            }
          }
          if (i < gridsize - 1 && j < gridsize - 1)
          {
            if (grid[i + 1, j + 1] == 1)
            {
              neighbors += 1;
            }
          }
          if (i < gridsize - 1)
          {
            if (grid[i + 1, j] == 1)
            {
              neighbors = neighbors + 1;
            }
          }
          if (i < gridsize - 1 && j > 0)
          {
            if (grid[i + 1, j - 1] == 1)
            {
              neighbors++;
            }
          }
          if (grid[i, j] == 1)
          {
            if (neighbors == 2 || neighbors == 3)
            {
              new_grid[i, j] = 1;
            }
            else
            {
              new_grid[i, j] = 0;
            }
          }
          else
          {
            if (neighbors == 3)
            {
              new_grid[i, j] = 1;
            }
            else
            {
              new_grid[i, j] = 0;
            }
          }

        }
      }

      // copy temp grid over original grid
      grid = new_grid;

      // clear the screen
      Console.Clear();
      // print our grid
      for (int i = 0; i < grid.GetLength(0); i++)
      {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
          Console.Write(grid[i, j]);
        }
        Console.WriteLine();
      }

      // Wait until enter is hit
      Console.ReadLine();
    }
  }
}

