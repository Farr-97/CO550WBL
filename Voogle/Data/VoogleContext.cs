using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Voogle.Pages.Models.Videos;
using Voogle.Pages.Models.Categories;

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
    }
}
