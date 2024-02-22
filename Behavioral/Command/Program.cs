using Command.CoffeeMachines;
using Command.TVs;
using Command.Kettles;

namespace Command.CoffeeMachines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new();
            KettleCommand kettleCommand = new(kettle);

            TV tv = new();
            TVCommand tvCommand = new(tv);

            // Also it can be a list of commands and not necessary for the same object
            CoffeeMachine coffeeMachine = new();
            List<ICommand> coffeeComans =
            [
                new CoffeeMachineGrind(coffeeMachine),
                new CoffeeMachineBrew(coffeeMachine),
                new CoffeeMachinePour(coffeeMachine),
            ];
            CoffeeMachineCommand coffeeMachineCommand = new(coffeeComans);
            
            SmartPult smartPult = new();

            smartPult.SetCommand(0, kettleCommand);
            smartPult.SetCommand(1, tvCommand);
            smartPult.SetCommand(2, coffeeMachineCommand);

            smartPult.ExecuteCommand(0);
            smartPult.UndoCommand();
            smartPult.ExecuteCommand(1);
            smartPult.UndoCommand();
            smartPult.ExecuteCommand(2);
            smartPult.UndoCommand();
        }
    }
}
