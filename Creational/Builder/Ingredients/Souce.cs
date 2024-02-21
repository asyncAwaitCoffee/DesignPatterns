using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ingredients
{
    internal class Souce
    {
        public string Name { get; set; }
        public Souce(string name)
        {
            Name = name;
        }
    }
}
