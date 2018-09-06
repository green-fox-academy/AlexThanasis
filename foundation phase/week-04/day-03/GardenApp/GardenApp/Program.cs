using System;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();
            garden.AddFlower("Purple");
            garden.AddFlower("Yellow");
            garden.AddTree("Green");
            garden.AddTree("Orange");

            garden.DaysHavePassed(3);
            garden.PrintInfo();
            garden.Watering(10);
            garden.PrintInfo();
            Console.ReadLine();
        }
    }
}
