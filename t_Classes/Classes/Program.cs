
using System;

class Classes
{
  public static void Main(string[] args)
  {
    DogInfo[] adoptableDogs = new DogInfo[5];

    for (int i = 0; i < 1; i++)
    {
      adoptableDogs[i] = new DogInfo();
      Console.WriteLine("Enter the dog's name, breed and age.");
      adoptableDogs[i].Name = Console.ReadLine();
      adoptableDogs[i].Breed = Console.ReadLine();
      adoptableDogs[i].Age = Convert.ToInt16(Console.ReadLine());
    }
    for (int i = 0; i < 1; i++)
    {

      Console.Write(adoptableDogs[i].GetDogInfo());
    }
  }
}

class DogInfo
{
  public string Name;
  public string Breed;
  public int Age;

  public string GetDogInfo()
  {
    return ("You should take " +  Name + " home because \n" + Breed
             + "s are incredible dogs and " + Age + "\nis the perfect age.");
  }
}