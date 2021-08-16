using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Voogle.Pages.Models.Videos;
using Voogle.Pages.Models.Categories;
using Voogle.Pages.Models.Requests;
using Voogle.Pages.Models.Feedback;
using Voogle.Pages.Models.Comments;

namespace Voogle.Data
{
    public class VoogleContext : DbContext
    {
        public VoogleContext (DbContextOptions<VoogleContext> options)
            : base(options)
        {
        }

        public DbSet<Voogle.Pages.Models.Videos.Video> Video { get; set; }

        public DbSet<Voogle.Pages.Models.Categories.Category> Category { get; set; }

        public DbSet<Voogle.Pages.Models.Requests.Request> Request { get; set; }

        public DbSet<Voogle.Pages.Models.Feedback.Feedback> Feedback { get; set; }

        public DbSet<Voogle.Pages.Models.Comments.Comment> Comment { get; set; }
    }
}
