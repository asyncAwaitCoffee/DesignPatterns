using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Chores
    {
        public void WashDishes()
        {
            Console.WriteLine("Washing dishes.");
        }

        public void WipeWindows()
        {
            Console.WriteLine("Wiping windows.");
        }

        public void MopFloor()
        {
            Console.WriteLine("Mopping floor.");
        }
    }
}
