using Observer.Platform;
using Observer.EventPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.SunscribersEvents
{
    internal class EventSubscriber(string name) : IEventObserver
    {
        public string Name { get; set; } = name;
        public void Subscribe(IEventObservable observable)
        {
            observable.AddObserver(NotifyMe);
        }

        public void Unsubscribe(IEventObservable observable)
        {
            observable.RemoveObserver(NotifyMe);
        }

        public void NotifyMe(PlatformProduct platformProduct)
        {
            Console.WriteLine($"Dear {Name}, we have a new video for you: {platformProduct.Title}");
        }
    }
}
