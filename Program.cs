using System;

namespace ClassesIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      Car adamsCar = new Car(2020, 50_000);
      adamsCar.Color = "Red";
      adamsCar.Make = "Mazda";
      adamsCar.Model = "3";

      Car drewsCar = new Car(2013, 35_500)
      {
        Color = "Silver",
        Make = "Audi",
        Model = "A6",
        Year = 2013
      };

      // Console.WriteLine(adamsCar.Make);
      // Console.WriteLine(adamsCar.Model);
      // Console.WriteLine(adamsCar.Description);
      // adamsCar.Drive(60_000);
      // Console.WriteLine(adamsCar._milesDriven);

      Console.WriteLine(adamsCar.Description);
      Console.WriteLine(drewsCar.Description);

    }
  }
}
