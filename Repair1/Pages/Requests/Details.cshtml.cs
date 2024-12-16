using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Repair1.Data;
using Repair1.models;

namespace Repair1.Pages.Requests
{
    public class DetailsModel : PageModel
    {
        private readonly Repair1.Data.Repair1Context _context;

        public DetailsModel(Repair1.Data.Repair1Context context)
        {
            _context = context;
        }

        public Request Request { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request.FirstOrDefaultAsync(m => m.RequestId == id);
            if (request == null)
            {
                return NotFound();
            }
            else
            {
                Request = request;
            }
            return Page();
        }
    }
}
