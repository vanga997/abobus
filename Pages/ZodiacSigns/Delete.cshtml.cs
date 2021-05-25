using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarriageAgencyWeb.Data;
using MarriageAgencyWeb.Models;

namespace MarriageAgencyWeb.Pages_ZodiacSigns
{
    public class DeleteModel : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public DeleteModel(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ZodiacSign ZodiacSign { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ZodiacSign = await _context.ZodiacSigns.FirstOrDefaultAsync(m => m.ZodiacId == id);

            if (ZodiacSign == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ZodiacSign = await _context.ZodiacSigns.FindAsync(id);

            if (ZodiacSign != null)
            {
                _context.ZodiacSigns.Remove(ZodiacSign);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
