using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EmailAdapter(PostService postService) : ISendEmail
    {
        PostService _postService = postService;
        public void SendEmail()
        {
            _postService.SendLetter();
        }

        public void TypeEmail()
        {
            _postService.WriteLetter();
        }
    }
}
