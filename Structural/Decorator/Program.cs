namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- John --");
            Console.WriteLine();

            RegularWorker john = new RegularWorker();
            john.DoWork();
            Console.WriteLine();

            Console.WriteLine("-- Concentrated John --");
            Console.WriteLine();

            ConcentratedWorker concentratedJohn = new ConcentratedWorker(john);
            concentratedJohn.DoWork();
        }
    }
}
