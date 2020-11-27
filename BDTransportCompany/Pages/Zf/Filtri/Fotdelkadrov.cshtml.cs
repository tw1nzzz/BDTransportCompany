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
    public class Fotdelkadrov : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Fotdelkadrov(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }
        public Positions Position { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Positions.FirstOrDefaultAsync(m => m.ID == id);

            if (Position == null)
            {
                return NotFound();
            }
            Staff = await _context.Staff.Where(m => m.PositionID == Position.ID).ToListAsync();
            return Page();
        }
    }
}

