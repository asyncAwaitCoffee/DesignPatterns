using Observer.Platform;
using Observer.EventPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.SunscribersEvents
{
    internal interface IEventObserver
    {
        public void Subscribe(IEventObservable observable);
        public void Unsubscribe(IEventObservable observable);
    }
}
