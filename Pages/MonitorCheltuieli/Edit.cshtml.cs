using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Monitor_Cheltuieli.Data;
using Monitor_Cheltuieli.Models;

namespace Monitor_Cheltuieli.Pages.MonitorCheltuieli
{
    public class EditModel : PageModel
    {
        private readonly Monitor_Cheltuieli.Data.Monitor_CheltuieliContext _context;

        public EditModel(Monitor_Cheltuieli.Data.Monitor_CheltuieliContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Monitor Monitor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monitor = await _context.Monitor.FirstOrDefaultAsync(m => m.ID == id);

            if (Monitor == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Monitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonitorExists(Monitor.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MonitorExists(int id)
        {
            return _context.Monitor.Any(e => e.ID == id);
        }
    }
}
