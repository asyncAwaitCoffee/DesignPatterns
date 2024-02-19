namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoughProductsMaker pizzaMaker = new PizzaMaker("Pizza Hat");

            DoughProductsMaker hotdogMaker = new HotdogMaker("Hotdog Hat");

            DoughProduct pepperoniPizza = CookDoughProduct(pizzaMaker, "Pepperoni");
            DoughProduct hottoDoggo = CookDoughProduct(pizzaMaker, "Hotto Doggo");

            Console.WriteLine(pepperoniPizza.Name);
            Console.WriteLine(hottoDoggo.Name);

            /*
             * + we may not know which maker will be passed as argument
             * + we can easily create and integrate new makers and products
             * + we delegate creation of the new objects from base class to corresponding derived classes 
             */

            DoughProduct CookDoughProduct(DoughProductsMaker maker, string name)
            {
                DoughProduct product = maker.Cook(name);
                return product;
            }
        }
    }
}
