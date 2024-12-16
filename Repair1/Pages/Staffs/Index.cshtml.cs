﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Repair1.Data.Repair1Context _context;

        public IndexModel(Repair1.Data.Repair1Context context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
