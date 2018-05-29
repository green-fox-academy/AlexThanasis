using System;

namespace garden_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();
            garden.PlantFlower("yellow", 20);
            garden.PlantFlower("blue", 10);
            garden.PlantTree("purple", 20);
            garden.PlantTree("orange", 5);

            Console.WriteLine(garden.PrintHowManyThirstyPlants());
            Console.ReadLine();
        }
    }
}
