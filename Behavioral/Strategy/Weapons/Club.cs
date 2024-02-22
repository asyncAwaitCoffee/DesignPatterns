using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Weapons
{
    internal class Club : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Bonk!");
        }
    }
}
