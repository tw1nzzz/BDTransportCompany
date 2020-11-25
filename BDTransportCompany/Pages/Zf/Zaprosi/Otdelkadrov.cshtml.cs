using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.Zf.Zaprosi
{
    public class Otdelkadrov : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Otdelkadrov (BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }
        public IList<Positions> Positions { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Positions = await _context.Positions.ToListAsync();
        }
    }
}