using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
            Color = color;
            WaterAbsorbation = 0.75f;
            WaterNecessity = 5;
            WaterAmount = 10;
        }

        
    }
}
