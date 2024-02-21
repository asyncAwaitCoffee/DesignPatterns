using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ingredients
{
    internal class Bread
    {
        public string Name { get; set; }
        public Bread(string name)
        {
            Name = name;
        }
    }
}
