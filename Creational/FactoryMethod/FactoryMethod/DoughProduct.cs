using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class DoughProduct
    {
        public string Name { get; set; }
        protected DoughProduct(string name)
        {
            Name = name;
        }
    }
}
