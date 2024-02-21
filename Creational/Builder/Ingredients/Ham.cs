using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Ingredients
{
    internal class Ham
    {
        public string Name { get; set; }
        public Ham(string name)
        {
            Name = name;
        }
    }
}
