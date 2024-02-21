using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Prototype
{
    abstract internal class AnimalPrototype
    {
        public string Name { get; set; }
        public int PackId { get; set; }
        protected AnimalPrototype(string name, int packId)
        {
            Name = name;
            PackId = packId;
        }
        abstract public AnimalPrototype Clone();
        public override string ToString()
        {
            return $"Pack #{PackId} : {Name}";
        }
    }
}
