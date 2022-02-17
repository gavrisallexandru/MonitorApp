using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Monitor_Cheltuieli.Data;
using Monitor_Cheltuieli.Models;

namespace Monitor_Cheltuieli.Pages.MonitorCheltuieli
{
    public class CreateModel : PageModel
    {
        private readonly Monitor_Cheltuieli.Data.Monitor_CheltuieliContext _context;

        public CreateModel(Monitor_Cheltuieli.Data.Monitor_CheltuieliContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Monitor Monitor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Monitor.Add(Monitor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
