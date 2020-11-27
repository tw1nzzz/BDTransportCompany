using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;
namespace BDTransportCompany.Pages.Zf.Filtri
{
    public class Fzakazi2 : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Fzakazi2(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Routes> Routes { get; set; }
        public Cargos Cargo { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cargo = await _context.Cargos.FirstOrDefaultAsync(m => m.ID == id);

            if (Cargo == null)
            {
                return NotFound();
            }
            Routes = await _context.Routes.Where(m => m.CargoID == Cargo.ID).ToListAsync();
            return Page();
        }
    }
}
