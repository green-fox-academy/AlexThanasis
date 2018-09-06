using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Tree : Plant
    {
        public Tree(string color, float waterAmount) : base(color, waterAmount)
        {
            Color = color;
            WaterAmount = waterAmount;
            WaterAsorbationLevel = 0.4f;
            WaterNecessity = 10;
            if (waterAmount < WaterNecessity)
            {
                NeedWater = true;
            }
            else
            {
                NeedWater = false;
            }
        }

        public void Watering(float amount)
        {
            WaterAmount += amount * WaterAsorbationLevel;
        }
    }
}
