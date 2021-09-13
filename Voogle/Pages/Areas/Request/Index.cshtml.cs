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

        public string TitleSort { get; set; }
        public string IdSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public new IList<Request> Request { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
        // using System;
            TitleSort = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            IdSort = sortOrder == "Id" ? "Id_desc" : "Id";



            IQueryable<Request> requestsIQ = from s in _context.Request
                                             select s;


            switch (sortOrder)
            {
                case "title_desc":
                requestsIQ = requestsIQ.OrderByDescending(s => s.Title);
                    break;
                case "Id":
                requestsIQ = requestsIQ.OrderBy(s => s.RequestID);
                    break;
                case "Id_desc":
                requestsIQ = requestsIQ.OrderByDescending(s => s.RequestID);
                    break;
                default:
                requestsIQ = requestsIQ.OrderBy(s => s.Title);
                    break;
            }

            Request = await _context.Request.ToListAsync();
        }
    }
}


