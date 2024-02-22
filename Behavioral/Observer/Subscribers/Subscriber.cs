using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Platform;

namespace Observer.Subscribers
{
    internal class Subscriber(string name) : IObserver
    {
        public string Name { get; set; } = name;

        public void Observe(PlatformProduct product)
        {
            Console.WriteLine($"New video for {Name}: {product.Title}");
        }

        public void Subscribe(IObservable observable)
        {
            observable.AddObserver(this);
        }
        public void Unsubscribe(IObservable observable)
        {
            observable.RemoveObserver(this);
        }
    }
}
