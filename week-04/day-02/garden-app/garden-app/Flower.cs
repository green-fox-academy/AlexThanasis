using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Flower : Plant
    {
        private float waterAsorbationLevel = 0.75f;

        public Flower(string color, float waterAmmount, bool needWater) : base(color, waterAmmount, needWater)
        {
            color = this.color;
            waterAmmount = this.waterAmount;
            if (waterAmmount < 5)
            {
                needWater = true;
            }
            else
            {
                needWater = false;
            }
        }
        public Flower()
        {
            color = "green";
            waterAmount = 20;
            if (waterAmount < 5)
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
            waterAmount = amount * waterAsorbationLevel;
        }
    }
}
