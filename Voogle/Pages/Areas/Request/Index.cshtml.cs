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
    public class IndexModel : PageModel
    {
        private readonly Voogle.Data.VoogleContext _context;

        public IndexModel(Voogle.Data.VoogleContext context)
        {
            _context = context;
        }

        public new IList<Request> Request { get;set; }

        public async Task OnGetAsync()
        {
            Request = await _context.Request.ToListAsync();
        }
    }
}
