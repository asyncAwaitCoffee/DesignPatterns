using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CoffeeMachines
{
    internal class CoffeeMachine
    {
        public void GrindBeans()
        {
            Console.WriteLine("Coffee machine is grinding beans.");
        }

        public void BrewCoffee()
        {
            Console.WriteLine("Coffee machine is brewing coffee.");
        }

        public void PourCoffee()
        {
            Console.WriteLine("Coffee machine is pouring coffee.");
        }
        public void StopGrindBeans()
        {
            Console.WriteLine("Coffee machine stopped grinding beans.");
        }

        public void StopBrewCoffee()
        {
            Console.WriteLine("Coffee machine stopped brewing coffee.");
        }

        public void StopPourCoffee()
        {
            Console.WriteLine("Coffee machine stopped pouring coffee.");
        }
    }
}
