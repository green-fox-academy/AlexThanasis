using System;

namespace garden_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();
            garden.PlantFlower("yellow", 4);
            garden.PlantFlower("blue", 8);
            garden.PlantTree("purple", 4);
            garden.PlantTree("orange", 20);

            Console.WriteLine(garden.PrintHowManyThirstyPlants());

            garden.DaysHasPassed(4);
            Console.WriteLine();

            Console.WriteLine(garden.PrintHowManyThirstyPlants());
            Console.WriteLine( );
            

            garden.WateringTheGarden(20);
            Console.WriteLine(garden.PrintHowManyThirstyPlants());
            Console.ReadLine();
        }
    }
}
