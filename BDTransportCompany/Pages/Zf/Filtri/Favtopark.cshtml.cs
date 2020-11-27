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
    public class Favtopark : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Favtopark(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<TypesOfCars> TypesOfCars { get; set; }
        public TypesOfCars TypesOfCars1 { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypesOfCars1 = await _context.TypesOfCars.FirstOrDefaultAsync(m => m.ID == id);

            if (TypesOfCars1 == null)
            {
                return NotFound();
            }
            TypesOfCars = await _context.TypesOfCars.Where(m => m.TypeofCar_ID == TypesOfCars1.ID).ToListAsync();
            return Page();
        }
    }
}

