    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Sharpie
    {
        private string Color;
        private float Width;
        private float InkAmount;

        public Sharpie(string Color, float Width)
        {
            this.Color = Color;
            this.Width = Width;
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }

        public float GetInkAmount
        {
            get 
            {
                return InkAmount;
            }
        }

    }
}
