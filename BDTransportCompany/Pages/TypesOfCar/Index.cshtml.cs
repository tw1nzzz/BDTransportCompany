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
    public class IndexModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public IndexModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<TypesOfCars> TypesOfCars { get;set; }

        public async Task OnGetAsync()
        {
            TypesOfCars = await _context.TypesOfCars.ToListAsync();
        }
    }
}
