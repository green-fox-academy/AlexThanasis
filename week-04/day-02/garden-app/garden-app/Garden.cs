using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Garden
    {
        public static List<Tree> trees = new List<Tree>();
        public static List<Flower> flowers = new List<Flower>();
        public Garden()
        {
            
        }

        public void PlantTree(string color, float waterAmount)
        {
            Tree tree = new Tree(color, waterAmount);
            trees.Add(tree) ;
        }

        public void PlantFlower(string color, float waterAmount)
        {
            Flower flower = new Flower(color, waterAmount);
            flowers.Add(flower);
        }

        public void WateringTheGarden(float waterAmount)
        {
            float waterPerPlant = waterAmount / GetHowManyThirstyTrees();
            foreach (var plant in flowers)
            {
                plant.Watering(waterPerPlant);
            }
            foreach (var tree in trees)
            {
                tree.Watering(waterPerPlant);
            }
        }
        public static int GetHowManyThirstyTrees()
        {
            int counter = 0;
            foreach (var plant in trees)
            {
                if (plant.NeedWater)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int GetHowManyThirstyFlowers()
        {
            int counter = 0;
            foreach (var plant in flowers)
            {
                if (plant.NeedWater)
                {
                    counter++;
                }
            }
            return counter;
        }
        public string PrintHowManyThirstyPlants()
        {
            int flowersNeedWater = GetHowManyThirstyFlowers();
            int treesNeedWater = GetHowManyThirstyTrees();
            return flowersNeedWater + " flower(s) and " +  treesNeedWater + " tree(s) are thirsty";
        }

        public void DaysHasPassed(int day)
        {
            foreach (var plant in trees)
            {
                plant.WaterAmount -= (float)day;
                Console.WriteLine(day);
                Console.WriteLine(plant.WaterAmount);
            }
            foreach (var plant in flowers)
            {
                plant.WaterAmount -= (float)day;
                Console.WriteLine(day);
                Console.WriteLine(plant.WaterAmount);
            }
        }

        public void PrintInfo()
        {

        }
    }
}
