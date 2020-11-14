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
    public class DeleteModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DeleteModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cargos = await _context.Cargos.FindAsync(id);

            if (Cargos != null)
            {
                _context.Cargos.Remove(Cargos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
