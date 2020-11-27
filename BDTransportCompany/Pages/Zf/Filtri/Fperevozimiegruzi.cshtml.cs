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
    public class Fperevozimiegruzi : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Fperevozimiegruzi (BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Cargos> Cargos { get; set; }
        public TypesOfCargos TypesOfCargo { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesOfCargo = await _context.TypesOfCargos.FirstOrDefaultAsync(m => m.ID == id);

            if (TypesOfCargo == null)
            {
                return NotFound();
            }
            Cargos = await _context.Cargos.Where(m => m.TypesOfCargosID == TypesOfCargo.ID).ToListAsync();
            return Page();
        }
    }
}

