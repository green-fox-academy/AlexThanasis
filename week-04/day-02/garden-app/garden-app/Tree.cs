using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Tree : Plant
    {
        public Tree(string color, float waterAmount) 
        {
            color = this.color;
            this.waterAmount = waterAmount;
            waterAsorbationLevel = 0.4f;
            waterNecessity = 10;
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
        
    }
}
