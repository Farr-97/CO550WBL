using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voogle.Pages.Models.Categories;
using Voogle.Pages.Models.Requests;

namespace Voogle.Pages.Models.Videos
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public string Publisher { get; set; }
        public int AvgRating { get; set; }
        public DateTime Duration { get; set; }
        public string Description { get; set; }
        public Request Request { get; set; }
        public Category Category { get; set; }
    }
}
