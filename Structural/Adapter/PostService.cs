using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PostService
    {
        public void WriteLetter()
        {
            Console.WriteLine("Writing a letter.");
        }
        public void SendLetter()
        {
            Console.WriteLine("Sending a letter.");
        }
    }
}
