using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Sandwiches;

namespace Builder
{
    internal class Chief
    {
        public Sandwich MakeSandwich(SandwichdBuilder sandwichdBuilder)
        {
            sandwichdBuilder.CreateSanwich();
            sandwichdBuilder.AddBread();
            sandwichdBuilder.AddSouce();
            sandwichdBuilder.AddHam();

            return sandwichdBuilder.Sandwich;
        }
    }
}
