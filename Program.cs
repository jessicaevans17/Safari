using System;
using System.Linq;
namespace Safari
{
  class Program
  {
    static void CreateData()
    {
      //   // create seen animals
      //   // 1. Reference the Database
      //   var db = new SafariContext();
      //   // 2. Do the thing
      //   var lions = new SeenAnimals
      //   {
      //     Species = "Lion",
      //     CountOfTimesSeen = 10,
      //     LocationOfLastSeen = "Desert"
      //   };
      //   db.Animals.Add(lions);
      //   // 3. Save the thing

      //   var tigers = new SeenAnimals
      //   {
      //     Species = "Tiger",
      //     CountOfTimesSeen = 20000,
      //     LocationOfLastSeen = "Jungle",
      //   };
      //   db.Animals.Add(tigers);

      //   var bears = new SeenAnimals
      //   {
      //     Species = "Bear",
      //     CountOfTimesSeen = 500000,
      //     LocationOfLastSeen = "Forest",
      //   };
      //   db.Animals.Add(bears);
      //   db.SaveChanges();
      //   var kangaroos = new SeenAnimals
      //   {
      //     Species = "Kangaroo",
      //     CountOfTimesSeen = 2,
      //     LocationOfLastSeen = "Australia",
      //   };
      //   db.Animals.Add(kangaroos);
      //   db.SaveChanges();

      //   var sloths = new SeenAnimals
      //   {
      //     Species = "Sloth",
      //     CountOfTimesSeen = 1,
      //     LocationOfLastSeen = "Jungle",
      //   };
      //   db.Animals.Add(sloths);
      //   db.SaveChanges();
    }

    static void UpdateCount()
    {
      var db = new SafariContext();
      var animalToUpdate = db.Animals.FirstOrDefault(animal => animal.Species == "Bear");
      animalToUpdate.CountOfTimesSeen = 10;
      db.SaveChanges();
    }
    static void UpdateLocation()
    {
      var db = new SafariContext();
      var animalToUpdate = db.Animals.FirstOrDefault(animal => animal.Species == "Bear");
      animalToUpdate.LocationOfLastSeen = "At Goldilocks' house";
      db.SaveChanges();
    }
    static void DisplayUserData()
    {
      // 1. Reference the database
      var db = new SafariContext();
      // 2. Do the stuff you wanna do
      var animalsISaw = db.Animals.Select(animal => animal.Species);
      foreach (var animal in animalsISaw)
      {
        Console.WriteLine($"I a saw a {animal}!");
      }
      db.SaveChanges();
    }
    static void DeleteDesertAnimals()
    {
      // 1. Reference the database
      var db = new SafariContext();
      // 2. Find the thing
      var animalsToRemove = db.Animals.FirstOrDefault(animal => animal.LocationOfLastSeen == "Desert");
      // 3. Delete the thingdot 
      db.Animals.Remove(animalsToRemove);
      // 4. Save the changes
      db.SaveChanges();
    }
    static void DisplayJungleAnimals()
    {
      var db = new SafariContext();
      var jungleAnimals = db.Animals.Where(animal => animal.LocationOfLastSeen == "Jungle");
      foreach (var animal in jungleAnimals)
      {
        Console.WriteLine($"I saw a {animal.Species} in the Jungle!");
      }
      db.SaveChanges();
    }
    static void AddAllTheAnimals()
    {
      var db = new SafariContext();
      var total = db.Animals.Sum(animal => animal.CountOfTimesSeen);
      Console.WriteLine($"You've seen a total of {total} animals today! Woah!");
      db.SaveChanges();
    }
    static void LionsTigersBearsOhMy()
    {
      var db = new SafariContext();
      var lionsTigersAndBears = db.Animals.Where(animal => animal.Species == "Lion" || animal.Species == "Tiger" || animal.Species == "Bear");
      var total = lionsTigersAndBears.Sum(animal => animal.CountOfTimesSeen);
      Console.WriteLine($"You seen a total of {total} lions, tigers, and bears today! Oh my!");
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Safari Time");
      //   CreateData();
      DisplayUserData();
      UpdateCount();
      UpdateLocation();
      DisplayJungleAnimals();
      //   DeleteDesertAnimals();
      AddAllTheAnimals();
      LionsTigersBearsOhMy();
    }
  }
}
