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

        public void PlantTree(Tree tree)
        {
            trees.Add(tree) ;
        }

        public void PlantFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public static void WateringTheGarden(float waterAmount)
        {
            foreach (var plant in trees)
            {
                plant.Watering(waterAmount);
            }
            foreach (var plant in flowers)
            {
                plant.Watering(waterAmount);
            }

        }
    }
}
