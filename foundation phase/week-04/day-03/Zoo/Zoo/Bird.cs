using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            Name = name;
        }

        public override void Feed()
        {
            Hunger--;
        }

        public override void Greet()
        {
            Console.WriteLine("Hrrrrr");
        }

        public override string WantChild()
        {
            return "want a child from an egg";
        }
    }
}
