namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            Chores chores = new Chores();
            Leisure leisure = new Leisure();

            HumanFacade human = new HumanFacade(work, chores, leisure);

            human.DoWork();
            Console.WriteLine();
            human.DoChores();
            Console.WriteLine();
            human.DoSomeWork();
            Console.WriteLine();
            human.DoLeisure();
        }
    }
}
