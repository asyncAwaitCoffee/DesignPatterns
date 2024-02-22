using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Platform;

namespace Observer.Subscribers
{
    internal interface IObserver
    {
        public void Observe(PlatformProduct product);
        public void Subscribe(IObservable observable);
        public void Unsubscribe(IObservable observable);
    }
}
