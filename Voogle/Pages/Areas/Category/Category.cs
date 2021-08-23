using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voogle.Pages.Videos.Custom;

namespace Voogle.Pages.Models.Categories
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Title { get; set; }

        public ICollection<Video> Videos { get; set; }
    }
}
