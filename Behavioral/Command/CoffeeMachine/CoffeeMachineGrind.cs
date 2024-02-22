using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CoffeeMachines
{
    internal class CoffeeMachineGrind(CoffeeMachine coffeeMachine) : ICommand
    {
        CoffeeMachine _coffeeMachine = coffeeMachine;
        public void Execute()
        {
            _coffeeMachine.GrindBeans();
        }

        public void Undo()
        {
            _coffeeMachine.StopGrindBeans();
        }
    }
}
