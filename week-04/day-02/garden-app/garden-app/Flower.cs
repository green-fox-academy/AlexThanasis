using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Flower : Plant
    {
        private float waterAsorbationLevel = 0.75f;

        public Flower(string color, int waterAmmount, bool needWater) : base(color, waterAmmount, needWater)
        {
            color = this.Color;
            waterAmmount = this.WaterAmount;
            if (waterAmmount < 5)
            {
                needWater = true;
            }
            else
            {
                needWater = false;
            }
        }

        public float Watering(int amount)
        {
            return amount * waterAsorbationLevel;
        }
    }
}
