using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Kettles
{
    internal class Kettle
    {
        public void Heat()
        {
            Console.WriteLine("Kettle is heating.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Kettle is turned off.");
        }
    }
}
