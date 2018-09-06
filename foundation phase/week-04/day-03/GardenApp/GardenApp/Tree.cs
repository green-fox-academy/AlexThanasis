using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            Color = color;
            WaterAbsorbation = 0.4f;
            WaterNecessity = 10;
            WaterAmount = 20;
        }


    }
}
