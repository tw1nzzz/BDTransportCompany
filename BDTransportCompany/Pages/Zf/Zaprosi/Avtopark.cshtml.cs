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
    public class Avtopark : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public Avtopark (BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IList<Cars> Cars { get; set; }
        public IList<CarsBrands> CarsBrands { get; set; }
        public IList<TypesOfCars> TypesOfCars { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<Positions> Positions { get; set; }

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
            CarsBrands = await _context.CarsBrands.ToListAsync();
            TypesOfCars = await _context.TypesOfCars.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Positions = await _context.Positions.ToListAsync();


        }
    }
}
