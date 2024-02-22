namespace Decorator
{
    internal class RegularWorker : Worker
    {
        public override void DoWork()
        {
            Console.WriteLine("Doing some important work.");
        }
    }
}
