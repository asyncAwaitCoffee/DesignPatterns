namespace Decorator
{
    internal class ConcentratedWorker(Worker worker) : Worker
    {
        Worker _worker = worker;
        public override void DoWork()
        {
            DoPreparation();
            _worker.DoWork();
        }

        public void DoPreparation()
        {
            Console.WriteLine("Preparing to work.");
        }
    }
}
