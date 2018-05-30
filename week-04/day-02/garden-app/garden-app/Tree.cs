using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Tree : Plant
    {
        public Tree(string color, float waterAmount) : base(color, waterAmount)
        {
            this.Color = color;
            this.WaterAmount = waterAmount;
            this.WaterAsorbationLevel = 0.4f;
            this.WaterNecessity = 10;
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
