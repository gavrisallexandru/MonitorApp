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
    public class IndexModel : PageModel
    {
        private readonly Monitor_Cheltuieli.Data.Monitor_CheltuieliContext _context;

        public IndexModel(Monitor_Cheltuieli.Data.Monitor_CheltuieliContext context)
        {
            _context = context;
        }

        public IList<Monitor> Monitor { get;set; }

        public async Task OnGetAsync()
        {
            Monitor = await _context.Monitor.ToListAsync();
        }
    }
}
