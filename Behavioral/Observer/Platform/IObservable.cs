using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Subscribers;

namespace Observer.Platform
{
    internal interface IObservable
    {
        public void Notify(PlatformProduct product);
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
    }
}
