using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Plant
    {
        private string color;
        private int waterAmmount;
        protected bool needWater;

        public Plant(string color, int waterAmmount, bool needWater)
        {
            this.color = color;
            this.waterAmmount = waterAmmount;
            this.needWater = needWater;
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public int WaterAmount
        {
            get
            {
                return waterAmmount;
            }
        }

        
    }
}
