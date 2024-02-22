using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.TVs
{
    internal class TVCommand(TV tv) : ICommand
    {
        TV _tv = tv;
        public void Execute()
        {
            _tv.TurnOn();
        }

        public void Undo()
        {
            _tv.TurnOff();
        }
    }
}
