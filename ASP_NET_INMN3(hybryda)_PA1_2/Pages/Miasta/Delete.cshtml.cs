﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN3_hybryda__PA1_2.Data;
using ASP_NET_INMN3_hybryda__PA1_2.Models;

namespace ASP_NET_INMN3_hybryda__PA1_2.Pages.Miasta
{
    public class DeleteModel : PageModel
    {
        private readonly ASP_NET_INMN3_hybryda__PA1_2.Data.Context _context;

        public DeleteModel(ASP_NET_INMN3_hybryda__PA1_2.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Miasto Miasto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Miasta == null)
            {
                return NotFound();
            }

            var miasto = await _context.Miasta.FirstOrDefaultAsync(m => m.Id == id);

            if (miasto == null)
            {
                return NotFound();
            }
            else 
            {
                Miasto = miasto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Miasta == null)
            {
                return NotFound();
            }
            var miasto = await _context.Miasta.FindAsync(id);

            if (miasto != null)
            {
                Miasto = miasto;
                _context.Miasta.Remove(Miasto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
