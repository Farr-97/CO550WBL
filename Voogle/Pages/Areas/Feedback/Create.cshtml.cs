using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Voogle.Data;

namespace Voogle.Pages.Models.Feedback
{
    public class CreateModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public CreateModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["VideoID"] = new SelectList(_context.Video, "VideoID", "VideoID");
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

            return RedirectToPage("./Index");
        }
    }
}
