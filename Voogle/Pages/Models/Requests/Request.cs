using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voogle.Pages.Models.Requests
{
    public class Request
    {
        public int RequestID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int Upvotes { get; set; }
        public int CategoryID { get; set; }
    }
}
