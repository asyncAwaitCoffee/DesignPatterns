using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class DoughProductsMaker
    {
        public string Name { get; set; }
        protected DoughProductsMaker(string name)
        {
            Name = name;
        }
        public abstract DoughProduct Cook(string name);
    }
}
