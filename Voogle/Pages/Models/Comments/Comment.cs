using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voogle.Pages.Models.Comments
{
    public class Comment
    {
        public int CommentID { get; set; }

        public DateTime Timestamp { get; set; }

        public string CommentDetail { get; set; }

        public int VideoID { get; set; }
    }
}
