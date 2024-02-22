using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Platform;
using static Observer.EventPlatform.IEventObservable;

namespace Observer.EventPlatform
{
    internal class StreamingEventPlatform : IEventObservable
    {
        private event SubscriberNotifier Subscribes;
        public void NewVideo(string title)
        {
            Notify(new VideoClip(title));
        }
        public void AddObserver(SubscriberNotifier subscriberNotifier)
        {
            // RemoveObserver(subscriberNotifier); // remove or check if already exists to prevent duplicates
            if (Subscribes != null)
            {
                foreach (var item in Subscribes.GetInvocationList())
                {
                    if (item.Equals(subscriberNotifier))
                    {
                        return;
                    }
                }
            }
            
            Subscribes += subscriberNotifier;
        }

        public void Notify(PlatformProduct platformProduct)
        {
            Subscribes.Invoke(platformProduct);
        }

        public void RemoveObserver(SubscriberNotifier subscriberNotifier)
        {
            Subscribes -= subscriberNotifier;
        }
    }
}
