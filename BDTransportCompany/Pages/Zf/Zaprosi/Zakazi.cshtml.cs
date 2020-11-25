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
    public class Zakazi : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Zakazi (BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Routes> Routes { get; set; }
        public IList<Cars> Cars { get; set; }
        public IList<Cargos> Cargos { get; set; }
        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Routes = await _context.Routes.ToListAsync();
            Cars = await _context.Cars.ToListAsync();
            Cargos = await _context.Cargos.ToListAsync();
            Staff = await _context.Staff.ToListAsync();

        }
    }
}