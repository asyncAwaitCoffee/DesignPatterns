using AbstractFactory.Factories;
using AbstractFactory.Weapons;
using AbstractFactory.Armors;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Abstarct fabric: EquipmentFactory
             * 
             * + we may not know which factory will be passed as argument
             * + we can easily create and integrate new factories
             * + factories may have several factory methods to return a group of related objects
             * 
             * - if we are adding a new method to the factory we also need to add it to all derrived factories
             * - it is harder to implement if each factory has a different amount of methods
             */

            var knight = CreateEquipment(new KnightEquipmentFactory());
            var mage = CreateEquipment(new MageEquipmentFactory());

            Console.WriteLine(knight);
            Console.WriteLine(mage);

            (Weapon, Armor) CreateEquipment(EquipmentFactory factory)
            {
                Weapon weapon = factory.CreateWeapon();
                Armor armor = factory.CreateArmor();

                return (weapon, armor);
            }
        }
    }
}
