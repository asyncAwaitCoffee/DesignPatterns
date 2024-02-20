using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Armors;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories
{
    internal class KnightEquipmentFactory : EquipmentFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Sword();
        }

        public override Armor CreateArmor()
        {
            return new Plate();
        }
    }
}
