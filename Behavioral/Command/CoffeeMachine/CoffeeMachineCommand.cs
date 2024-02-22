using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.CoffeeMachines
{
    internal class CoffeeMachineCommand(List<ICommand> coffeeMachineCommands) : ICommand
    {
        List<ICommand> _coffeeMachineCommands = coffeeMachineCommands;
        public void Execute()
        {
            foreach (var command in _coffeeMachineCommands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _coffeeMachineCommands)
            {
                command.Undo();
            }
        }
    }
}
