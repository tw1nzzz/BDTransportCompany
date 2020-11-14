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

namespace BDTransportCompany.Pages.TypesOfCar
{
    public class EditModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public EditModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TypesOfCars TypesOfCars { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesOfCars = await _context.TypesOfCars.FirstOrDefaultAsync(m => m.ID == id);

            if (TypesOfCars == null)
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

            _context.Attach(TypesOfCars).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypesOfCarsExists(TypesOfCars.ID))
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

        private bool TypesOfCarsExists(long id)
        {
            return _context.TypesOfCars.Any(e => e.ID == id);
        }
    }
}
