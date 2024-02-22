using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EmailService : ISendEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending email.");
        }

        public void TypeEmail()
        {
            Console.WriteLine("Typing text for email.");
        }
    }
}
