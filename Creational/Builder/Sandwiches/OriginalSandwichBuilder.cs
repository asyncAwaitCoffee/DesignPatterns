using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sandwiches
{
    internal class OriginalSandwichBuilder : SandwichdBuilder
    {
        public override void AddBread()
        {
            Sandwich.Bread = new Ingredients.Bread("White Bread");
        }

        public override void AddHam()
        {
            Sandwich.Ham = new Ingredients.Ham("Double Ham");
        }

        public override void AddSouce()
        {
            Sandwich.Souce = new Ingredients.Souce("Mayo Souce");
        }
    }
}
