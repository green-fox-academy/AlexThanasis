using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Flower : Plant
    {
        public Flower(string color, float waterAmount)
        {
            color = this.color;
            this.waterAmount = waterAmount;
            waterAsorbationLevel = 0.75f;
            waterNecessity = 5;
            if (waterAmount < waterNecessity)
            {
                needWater = true;
            }
            else
            {
                needWater = false;
            }
        }

        public void Watering(float amount)
        {
            waterAmount += amount * waterAsorbationLevel;
        }

        public bool NeedWater
        {
            get
            {
                return needWater;
            }
        }
    }
}
