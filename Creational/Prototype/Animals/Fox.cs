using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Prototype;

namespace Prototype.Animals
{
    internal class Fox : AnimalPrototype
    {
        public Fox(string name, int packId) : base(name, packId) { }
        public override AnimalPrototype Clone()
        {
            return new Fox(Name, PackId);
        }
    }
}
