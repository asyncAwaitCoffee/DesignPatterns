using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DoughProducts
{
    internal class Hotdog : DoughProduct
    {
        public Hotdog(string name) : base(name)
        {
        }
    }
}
