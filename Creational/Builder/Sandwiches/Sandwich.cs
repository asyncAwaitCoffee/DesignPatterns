using Builder.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Sandwiches
{
    internal class Sandwich
    {
        public Bread? Bread { get; set; }
        public Souce? Souce { get; set; }
        public Ham? Ham { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Bread != null)
            {
                sb.AppendLine(Bread.Name);
            }

            if (Souce != null)
            {
                sb.AppendLine(Souce.Name);
            }

            if (Ham != null)
            {
                sb.AppendLine(Ham.Name);
            }

            return sb.ToString();
        }
    }
}
