using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Voogle.Data;

namespace Voogle.Pages.Models.Requests
{
    public class DetailsModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public DetailsModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }

        public new Request Request { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Request = await _context.Request.FirstOrDefaultAsync(m => m.RequestID == id);

            if (Request == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
