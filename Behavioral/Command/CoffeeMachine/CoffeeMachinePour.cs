using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CoffeeMachines
{
    internal class CoffeeMachinePour(CoffeeMachine coffeeMachine) : ICommand
    {
        CoffeeMachine _coffeeMachine = coffeeMachine;
        public void Execute()
        {
            _coffeeMachine.PourCoffee();
        }

        public void Undo()
        {
            _coffeeMachine.StopPourCoffee();
        }
    }
}
