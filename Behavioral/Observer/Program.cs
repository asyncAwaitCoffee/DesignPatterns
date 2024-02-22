using Observer.EventPlatform;
using Observer.Platform;
using Observer.Subscribers;
using Observer.SunscribersEvents;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamingPlatform streamingPlatform = new StreamingPlatform();
            Subscriber subscriberAnna = new Subscriber("Anna");
            Subscriber subscriberJohn = new Subscriber("John");

            subscriberAnna.Subscribe(streamingPlatform);
            streamingPlatform.NewVideo("Cute cats!");

            subscriberJohn.Subscribe(streamingPlatform);
            streamingPlatform.NewVideo("Cute dogs!");

            subscriberAnna.Unsubscribe(streamingPlatform);
            streamingPlatform.NewVideo("Cute turtles!");

            Console.WriteLine();
            Console.WriteLine("--- Observe using events ---");
            Console.WriteLine();

            StreamingEventPlatform streamingEventPlatform = new StreamingEventPlatform();
            EventSubscriber subscriberLily = new EventSubscriber("Lily");
            EventSubscriber subscriberBen = new EventSubscriber("Ben");

            subscriberLily.Subscribe(streamingEventPlatform);
            streamingEventPlatform.NewVideo("Sunny vibes at the sea");

            subscriberBen.Subscribe(streamingEventPlatform);
            streamingEventPlatform.NewVideo("Never Give Up!");

            subscriberLily.Unsubscribe(streamingEventPlatform);
            streamingEventPlatform.NewVideo("Strange Events");


        }
    }
}
