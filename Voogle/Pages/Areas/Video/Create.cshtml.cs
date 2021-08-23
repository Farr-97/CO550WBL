using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Voogle.Data;
using Voogle.Pages.Videos.Custom;

namespace Voogle.Pages.Videos.Crud
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
            return Page();
        }

        [BindProperty]
        public Video Video { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Video> entityEntry = _context.Video.Add(Video);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
