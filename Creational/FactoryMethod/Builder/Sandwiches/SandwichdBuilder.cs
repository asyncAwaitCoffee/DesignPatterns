using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sandwiches
{
    internal abstract class SandwichdBuilder
    {
        public Sandwich Sandwich { get; private set; }
        public void CreateSanwich()
        {
            Sandwich = new Sandwich();
        }

        public abstract void AddBread();
        public abstract void AddSouce();
        public abstract void AddHam();
    }
}
