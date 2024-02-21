using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sandwiches
{
    internal class ChilliSandwichBuilder : SandwichdBuilder
    {
        public override void AddBread()
        {
            Sandwich.Bread = new Ingredients.Bread("Rye Bread");
        }

        public override void AddHam()
        {
            Sandwich.Ham = new Ingredients.Ham("Chicken Ham");
        }

        public override void AddSouce()
        {
            Sandwich.Souce = new Ingredients.Souce("Chilli Souce");
        }
    }
}
