using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.Car
{
    public class DetailsModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public DetailsModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public Cars Cars { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FirstOrDefaultAsync(m => m.ID == id);

            if (Cars == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
