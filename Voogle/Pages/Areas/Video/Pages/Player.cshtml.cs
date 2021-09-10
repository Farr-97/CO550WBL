using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Voogle.Data;
using Voogle.Pages.Models.Feedback;
using Voogle.Pages.Videos.Custom;

namespace Voogle.Pages.Videos.Custom
{
    public class PlayerModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public PlayerModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }

        public IList<Feedback> FeedbackList { get; set; }

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

        [BindProperty]
        public Feedback Feedback { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Feedback.Add(Feedback);
            await _context.SaveChangesAsync();

            return Redirect("~/Areas/Video/Index");

        }


    }
}


