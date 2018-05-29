using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Plant
    {
        protected string color;
        protected float waterAmount;
        protected bool needWater;
        protected float waterAsorbationLevel;
        protected float waterNecessity;

        public Plant(string color, float waterAmount, float waterNecessity)
        {
            this.color = color;
            this.waterAmount = waterAmount;
            if (waterAmount < this.waterNecessity)
            {
                needWater = true;
            }
            else
            {
                needWater = false;
            }

        }
        public Plant()
        {
            color = "green";
            waterAmount = 40;
            needWater = false;
        }
    }
}
