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
    public class Perevozimiegruzi : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Perevozimiegruzi (BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Cargos> Cargos { get; set; }
        public IList<TypesOfCargos> TypesOfCargos { get; set; }

        public async Task OnGetAsync()
        {
            Cargos = await _context.Cargos.ToListAsync();
            TypesOfCargos = await _context.TypesOfCargos.ToListAsync();
        }
    }
}