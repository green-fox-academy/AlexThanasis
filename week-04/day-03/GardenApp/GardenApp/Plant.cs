using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    public abstract class Plant
    {
        private string color;
        private float waterAmount;
        private float waterAbsorbation;
        private float waterNecessity;

        public Plant()
        {
        }

        public Plant(string color)
        {
            this.color = color;
        }

        public float WaterAmount { get => waterAmount; set => waterAmount = value; }
        public float WaterAbsorbation { get => waterAbsorbation; set => waterAbsorbation = value; }
        public string Color { get => color; set => color = value; }
        public float WaterNecessity { get => waterNecessity; set => waterNecessity = value; }
    }
}
