using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Prototype.Prototype;

namespace Prototype.Animals
{
    internal class Wolf : AnimalPrototype
    {
        public Wolf(string name, int packId) : base(name, packId) { }

        public override AnimalPrototype Clone()
        {
            return new Wolf(Name, PackId);
        }
    }
}
