using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.TypesOfCargo
{
    public class DeleteModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DeleteModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TypesOfCargos TypesOfCargos { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesOfCargos = await _context.TypesOfCargos.FirstOrDefaultAsync(m => m.ID == id);

            if (TypesOfCargos == null)
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

            TypesOfCargos = await _context.TypesOfCargos.FindAsync(id);

            if (TypesOfCargos != null)
            {
                _context.TypesOfCargos.Remove(TypesOfCargos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
