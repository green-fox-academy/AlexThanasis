using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Tree : Plant
    {
        private float waterAsorbationLevel = 0.4f;

        public Tree(string color, int waterAmmount, bool needWater) : base(color, waterAmmount, needWater)
        {
            color = this.Color;
            waterAmmount = this.WaterAmount;
            if (waterAmmount < 10)
            {
                needWater = true;
            }
            else
            {
                needWater = false;
            }
        }
    }
}
