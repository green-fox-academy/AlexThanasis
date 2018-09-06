using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Garden
    {
        public List<Plant> plants = new List<Plant>();

        public Garden()
        {

        }

        public void AddFlower(String color)
        {
            Flower flower = new Flower(color);
            plants.Add(flower);
        }

        public void AddTree(String color)
        {
            Tree tree = new Tree(color);
            plants.Add(tree);
        }

        public void PrintInfo()
        {
            
            for (int i = 0; i < plants.Count; i++)
            {
                Console.WriteLine("Color: " + plants[i].Color + ", water amount: " + plants[i].WaterAmount);
                Console.WriteLine("-------------------");
            }
        }

        public void Watering(float wateringInput)
        {
            foreach (var plant in plants)
            {
                if (plant.WaterAmount < plant.WaterNecessity)
                {
                    plant.WaterAmount += (wateringInput / GetHowManyThirstyPlants());
                }
            }
        }

        public float GetHowManyThirstyPlants()
        {
            int counter = 0;
            foreach (var plant in plants)
            {
                if (plant.WaterAmount < plant.WaterNecessity)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void DaysHavePassed(int days)
        {
            foreach (var plant in plants)
            {
                plant.WaterAmount -= 2 * days;
            }
        }
    }
}
