using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Voogle.Pages.Models.Feedback;
using Voogle.Pages.Models.Requests;
using System.Linq;

namespace Voogle.Pages.Videos.Custom
{
    public class Video
    {
        public int VideoID { get; set; }
        [Display(Name = "Video Title")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Upload Date")]
        public DateTime UploadDate { get; set; }
        [Display(Name = "Publisher Name")]
        public string Publisher { get; set; }
        public decimal AvgRating { get; set; }
        public TimeSpan Duration { get; set; }
        [Display(Name = "Video Description")]
        public string Description { get; set; }
        [Display(Name = "Video URL link")]
        public string VideoURL { get; set; }

        public int RequestID { get; set; }
        public Request Request { get; set; }

        ICollection<Feedback> Feedbacks { get; set; }
    }
}
