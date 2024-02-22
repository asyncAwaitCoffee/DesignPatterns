using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CoffeeMachines
{
    internal class CoffeeMachineBrew(CoffeeMachine coffeeMachine) : ICommand
    {
        CoffeeMachine _coffeeMachine = coffeeMachine;
        public void Execute()
        {
            _coffeeMachine.BrewCoffee();
        }

        public void Undo()
        {
            _coffeeMachine.StopBrewCoffee();
        }
    }
}
