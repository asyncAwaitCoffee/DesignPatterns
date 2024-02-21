using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Armors;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories
{
    internal abstract class EquipmentFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Armor CreateArmor();
    }
}
