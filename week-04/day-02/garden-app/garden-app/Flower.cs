using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Flower : Plant
    {
        public Flower(string color, float waterAmount) : base(color, waterAmount)
        {
            Color = color;
            WaterAmount = waterAmount;
            WaterAsorbationLevel = 0.75f;
            WaterNecessity = 5;
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
