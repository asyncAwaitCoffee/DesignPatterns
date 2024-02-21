using Prototype.Animals;
using Prototype.Prototype;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Allows to get a new object with prefilled data
             */
            Wolf wolf = new Wolf("Grey", 1);
            Fox fox = new Fox("Red", 2);

            AnimalPrototype clonedWolf = wolf.Clone();
            AnimalPrototype clonedFox = fox.Clone();

            clonedWolf.Name = "Black";
            clonedFox.Name = "White";

            Console.WriteLine(wolf);
            Console.WriteLine(fox);
            Console.WriteLine(clonedWolf);
            Console.WriteLine(clonedFox);
        }

        
    }
}
