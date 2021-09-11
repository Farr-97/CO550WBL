using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Voogle.Pages.Models.Feedback
{
    public class IndexModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public IndexModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }


        public IList<Feedback> Feedback { get;set; }

        public async Task OnGetAsync(string searchString)
        {

            Feedback = await _context.Feedback.ToListAsync();

        }
    }
}
