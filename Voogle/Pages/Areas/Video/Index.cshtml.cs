using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Voogle.Data;
using Voogle.Pages.Videos.Custom;

namespace Voogle.Pages.Videos.Crud
{
    public class IndexModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public IndexModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }

        public IList<Video> Video { get;set; }

        public async Task OnGetAsync()
        {
            Video = await _context.Video.ToListAsync();
        }
    }
}
