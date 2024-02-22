using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Platform
{
    internal abstract class PlatformProduct(string title)
    {
        public string Title { get; set; } = title;
    }
}
