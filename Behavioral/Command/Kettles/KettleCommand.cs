using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Kettles
{
    internal class KettleCommand(Kettle kettle) : ICommand
    {
        private Kettle _kettle = kettle;

        public void Execute()
        {
            _kettle.Heat();
        }

        public void Undo()
        {
            _kettle.TurnOff();
        }
    }
}
