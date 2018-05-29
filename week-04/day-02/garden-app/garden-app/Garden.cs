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

        public static void WateringTheGarden(float waterAmount)
        {
            foreach (var plant in trees)
            {
                waterAmount /= GetHowManyThirstyTrees();
                plant.Watering(waterAmount);
            }
            foreach (var plant in flowers)
            {
                waterAmount /= GetHowManyThirstyTrees();
                plant.Watering(waterAmount);
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
                plant.WaterAmount -= day * 2;
            }
            foreach (var plant in flowers)
            {
                plant.WaterAmount -= day * 2;
            }
        }
    }
}

