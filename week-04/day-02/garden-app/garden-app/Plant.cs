using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Plant
    {
        private string color;
        private int waterAmmount;
        protected bool needToWater;

        public Plant(string color, int waterAmmount, bool needToWater)
        {
            this.color = color;
            this.waterAmmount = waterAmmount;
            this.needToWater = needToWater;
        }
        

    }
}
