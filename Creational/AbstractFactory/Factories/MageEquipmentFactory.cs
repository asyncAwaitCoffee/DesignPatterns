using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Armors;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories
{
    internal class MageEquipmentFactory : EquipmentFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Staff();
        }

        public override Armor CreateArmor()
        {
            return new Robe();
        }
    }
}
