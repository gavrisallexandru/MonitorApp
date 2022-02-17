using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Monitor_Cheltuieli.Models;

namespace Monitor_Cheltuieli.Data
{
    public class Monitor_CheltuieliContext : DbContext
    {
        public Monitor_CheltuieliContext (DbContextOptions<Monitor_CheltuieliContext> options)
            : base(options)
        {
        }

        public DbSet<Monitor_Cheltuieli.Models.Monitor> Monitor { get; set; }
    }
}
