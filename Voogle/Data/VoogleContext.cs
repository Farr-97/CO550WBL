using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Voogle.Pages.Models.Categories;
using Voogle.Pages.Models.Requests;
using Voogle.Pages.Models.Feedback;
using Voogle.Pages.Models.Comments;
using Voogle.Pages.Videos.Custom;

namespace Voogle.Data
{
    public class VoogleContext : DbContext
    {
        public VoogleContext (DbContextOptions<VoogleContext> options)
            : base(options)
        {
        }

        public DbSet<Video> Video { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Request> Request { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>().ToTable("Video");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Request>().ToTable("Request");
            modelBuilder.Entity<Feedback>().ToTable("Feedback");
            modelBuilder.Entity<Comment>().ToTable("Comment");
        }

    }
}
