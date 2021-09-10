using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voogle.Pages.Models.Feedback
{
    public class Feedback
    {
        public int FeedbackID { get; set; }

        public string Description { get; set; }
        
        public decimal Rating { get; set; }

        public int VideoID { get; set; }
    }
}
