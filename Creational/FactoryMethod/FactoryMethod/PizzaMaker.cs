using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PizzaMaker : DoughProductsMaker
    {
        public PizzaMaker(string name) : base(name) { }

        public override DoughProduct Cook(string name)
        {
            return new Pizza(name);
        }
    }
}
