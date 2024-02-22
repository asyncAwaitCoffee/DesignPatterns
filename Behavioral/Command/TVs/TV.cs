using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.TVs
{
    internal class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is on turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is turned off.");
        }
    }
}
