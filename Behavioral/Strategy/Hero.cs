using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Hero
    {
        private string _name;
        public Hero(string name)
        {
            _name = name;
        }
        private IWeapon _weapon = new Knuckle();
        public void EquipWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void DoAttack()
        {
            Console.WriteLine($"{_name} attacks!");
            _weapon.Attack();
        }
    }
}
