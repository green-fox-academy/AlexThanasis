using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        private int Count;

        public Counter ()
        {
            Count = 0;
        }
        public Counter (int startingNumber)
        {
            this.Count = startingNumber;
        }
        public void Add (int number)
        {
            Count += number;
        }
        public void Add ()
        {
            Count++;
        }
        public string Get
        {
            get
            {
                return Count.ToString();
            }
        }
        public void Reset()
        {
            Count = 0;
        }


    }
}
