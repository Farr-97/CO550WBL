using System;
using Voogle.Pages.Models.Categories;
using Voogle.Pages.Models.Requests;

namespace Voogle.Pages.Videos.Custom
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public string Publisher { get; set; }
        public int AvgRating { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public Request Request { get; set; }
        public Category Category { get; set; }
    }
}
