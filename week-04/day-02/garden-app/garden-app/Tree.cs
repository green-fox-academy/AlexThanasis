using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Tree : Plant
    {
        private float waterAsorbationLevel = 0.4f;

        public Tree(string color, float waterAmount, bool needWater) : base(color, waterAmount, needWater)
        {
            color = this.color;
            this.waterAmount = waterAmount;
            waterAsorbationLevel = 0.4f;
            this.waterNecessity = 10;
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
            waterAmount = amount * waterAsorbationLevel;
        }
        
    }
}
