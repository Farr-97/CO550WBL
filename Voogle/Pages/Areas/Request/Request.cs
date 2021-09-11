using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voogle.Pages.Videos.Custom;

namespace Voogle.Pages.Models.Requests
{
    public class Request
    {
        public int RequestID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
