using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.TypesOfCar
{
    public class DeleteModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DeleteModel(BDTransportCompany.Data.BDTransportCompanyContext context)
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesOfCars = await _context.TypesOfCars.FindAsync(id);

            if (TypesOfCars != null)
            {
                _context.TypesOfCars.Remove(TypesOfCars);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
