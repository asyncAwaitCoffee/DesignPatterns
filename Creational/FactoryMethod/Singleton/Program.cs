namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread otherThread = new Thread(() =>
            {
                Console.WriteLine(Singleton.Instance().DateTime);
            });
            otherThread.Start();

            Console.WriteLine(Singleton.Instance().DateTime);
        }

        public class Singleton
        {
            private static Singleton _singleton = null;
            private static object _lock = new object();

            public DateTime DateTime { get; private set; }
            private Singleton()
            {
                DateTime = DateTime.Now;
            }

            public static Singleton Instance()
            {
                if (_singleton == null)
                {
                    lock (_lock)
                    {
                        if (_singleton == null)
                        {
                            _singleton = new Singleton();
                        }
                    }
                }

                return _singleton;
            }
        }
    }
}
