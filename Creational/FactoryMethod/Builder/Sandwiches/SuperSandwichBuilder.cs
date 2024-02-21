using Builder.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sandwiches
{
    internal static class SuperSandwichBuilder
    {
        public static Sandwich CreateSanwich()
        {
             return new Sandwich();
        }
        public static Sandwich AddBread(this Sandwich sandwich, string bread)
        {
            sandwich.Bread = new Bread(bread);
            return sandwich;
        }
        public static Sandwich AddSouce(this Sandwich sandwich, string souce)
        {
            sandwich.Souce = new Souce(souce);
            return sandwich;
        }
        public static Sandwich AddHam(this Sandwich sandwich, string ham)
        {
            sandwich.Ham = new Ham(ham);
            return sandwich;
        }
    }
}
