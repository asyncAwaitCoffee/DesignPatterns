using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class User
    {
        public void SendReport(ISendEmail mailService)
        {
            mailService.TypeEmail();
            mailService.SendEmail();
        }
    }
}
