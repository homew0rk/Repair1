using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Repair1.Data;
using Repair1.models;

namespace Repair1.Pages.Staffs
{
    public class DetailsModel : PageModel
    {
        private readonly Repair1.Data.Repair1Context _context;

        public DetailsModel(Repair1.Data.Repair1Context context)
        {
            _context = context;
        }

        public Staff Staff { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FirstOrDefaultAsync(m => m.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }
            else
            {
                Staff = staff;
            }
            return Page();
        }
    }
}
