using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.Cargo
{
    public class DetailsModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DetailsModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public Cargos Cargos { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cargos = await _context.Cargos.FirstOrDefaultAsync(m => m.ID == id);

            if (Cargos == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
