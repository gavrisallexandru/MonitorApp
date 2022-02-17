using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Monitor_Cheltuieli.Data;
using Monitor_Cheltuieli.Models;

namespace Monitor_Cheltuieli.Pages.MonitorCheltuieli
{
    public class DetailsModel : PageModel
    {
        private readonly Monitor_Cheltuieli.Data.Monitor_CheltuieliContext _context;

        public DetailsModel(Monitor_Cheltuieli.Data.Monitor_CheltuieliContext context)
        {
            _context = context;
        }

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
    }
}
