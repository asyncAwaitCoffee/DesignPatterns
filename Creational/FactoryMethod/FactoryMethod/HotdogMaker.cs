using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class HotdogMaker : DoughProductsMaker
    {
        public HotdogMaker(string name) : base(name)
        {
        }

        public override DoughProduct Cook(string name)
        {
            return new Hotdog(name);
        }
    }
}
