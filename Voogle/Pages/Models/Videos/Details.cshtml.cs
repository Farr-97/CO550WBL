using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Voogle.Data;

namespace Voogle.Pages.Models.Videos
{
    public class DetailsModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public DetailsModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }

        public Video Video { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Video = await _context.Video.FirstOrDefaultAsync(m => m.VideoID == id);

            if (Video == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
