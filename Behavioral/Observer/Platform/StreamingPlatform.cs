using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Subscribers;

namespace Observer.Platform
{
    internal class StreamingPlatform : IObservable
    {
        List<IObserver> _observers = new();

        public void NewVideo(string title)
        {
            Notify(new VideoClip(title));
        }
        public void Notify(PlatformProduct product)
        {
            foreach (var observer in _observers)
            {
                observer.Observe(product);
            }
        }

        public void AddObserver(IObserver observer)
        {
            //RemoveObserver(observer); // remove or check if already exists to prevent duplicates
            if (_observers.Contains(observer))
            {
                return;
            }
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
