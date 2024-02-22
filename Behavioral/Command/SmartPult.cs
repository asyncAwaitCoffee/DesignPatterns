using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SmartPult
    {
        ICommand[] _commands = new ICommand[3];
        Stack<ICommand> _stack = new Stack<ICommand>();

        public void SetCommand(int button, ICommand command)
        {
            _commands[button] = command;
        }

        public void ExecuteCommand(int button)
        {
            _commands[button].Execute();
            _stack.Push(_commands[button]);
        }

        public void UndoCommand()
        {
            ICommand toUndoCommand = _stack.Pop();
            toUndoCommand.Undo();
        }
    }
}
