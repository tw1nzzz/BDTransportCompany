using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDTransportCompany.Models;

namespace BDTransportCompany.Data
{
    public class BDTransportCompanyContext : DbContext
    {
        public BDTransportCompanyContext (DbContextOptions<BDTransportCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<BDTransportCompany.Models.Staff> Staff { get; set; }

        public DbSet<BDTransportCompany.Models.Positions> Positions { get; set; }

        public DbSet<BDTransportCompany.Models.TypesOfCars> TypesOfCars { get; set; }

        public DbSet<BDTransportCompany.Models.CarsBrands> CarsBrands { get; set; }

        public DbSet<BDTransportCompany.Models.TypesOfCargos> TypesOfCargos { get; set; }

        public DbSet<BDTransportCompany.Models.Cargos> Cargos { get; set; }

        public DbSet<BDTransportCompany.Models.Cars> Cars { get; set; }

        public DbSet<BDTransportCompany.Models.Routes> Routes { get; set; }
    }
}
