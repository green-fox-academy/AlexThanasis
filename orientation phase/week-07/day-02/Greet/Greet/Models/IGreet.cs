using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greet.Models
{
    interface IGreeting
    {
        void GetName(string inputName);
        string GreetSomeone(string inputName);
    }
}
