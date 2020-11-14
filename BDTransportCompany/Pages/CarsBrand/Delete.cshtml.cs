using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.CarsBrand
{
    public class DeleteModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DeleteModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarsBrands CarsBrands { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarsBrands = await _context.CarsBrands.FirstOrDefaultAsync(m => m.ID == id);

            if (CarsBrands == null)
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

            CarsBrands = await _context.CarsBrands.FindAsync(id);

            if (CarsBrands != null)
            {
                _context.CarsBrands.Remove(CarsBrands);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
