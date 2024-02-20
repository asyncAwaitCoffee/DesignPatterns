namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoughProductsMaker pizzaMaker = new PizzaMaker("Pizza Hat");
            DoughProductsMaker hotdogMaker = new HotdogMaker("Hotdog Hat");

            /*  Fabric method: Cook
             *  
             * + we can easily create and integrate new makers and products
             * + we delegate creation of the new objects from base class to corresponding derived classes 
             * + also can be implemented as interface
             */

            DoughProduct pepperoniPizza = pizzaMaker.Cook("Pepperoni");
            DoughProduct hottoDoggo = hotdogMaker.Cook("Hotto Doggo");

            Console.WriteLine(pepperoniPizza.Name);
            Console.WriteLine(hottoDoggo.Name);
        }
    }
}
