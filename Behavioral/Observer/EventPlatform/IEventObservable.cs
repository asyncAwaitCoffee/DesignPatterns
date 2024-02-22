using Observer.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.EventPlatform
{
    internal interface IEventObservable
    {
        delegate void SubscriberNotifier(PlatformProduct platformProduct);
        public void AddObserver(SubscriberNotifier subscriberNotifier);
        public void RemoveObserver(SubscriberNotifier subscriberNotifier);
        public void Notify(PlatformProduct platformProduct);
    }
}
