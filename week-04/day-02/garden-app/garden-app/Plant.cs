using System;
using System.Collections.Generic;
using System.Text;

namespace garden_app
{
    class Plant
    {
        private string color;
        private float waterAmount;
        private bool needWater;
        private float waterAsorbationLevel;
        private float waterNecessity;

        public string Color { get => color; set => color = value; }
        public float WaterAmount { get => waterAmount; set => waterAmount = value; }
        public bool NeedWater { get => needWater; set => needWater = value; }
        public float WaterAsorbationLevel { get => waterAsorbationLevel; set => waterAsorbationLevel = value; }
        public float WaterNecessity { get => waterNecessity; set => waterNecessity = value; }

        public Plant(string color, float waterAmount)
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
