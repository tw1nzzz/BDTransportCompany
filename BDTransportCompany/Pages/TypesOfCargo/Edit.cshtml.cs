using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.TypesOfCargo
{
    public class EditModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public EditModel(BDTransportCompany.Data.BDTransportCompanyContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TypesOfCargos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypesOfCargosExists(TypesOfCargos.ID))
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

        private bool TypesOfCargosExists(long id)
        {
            return _context.TypesOfCargos.Any(e => e.ID == id);
        }
    }
}
