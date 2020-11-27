using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BDTransportCompany.Pages.Zf
{
    public class IndexModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public IndexModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;

        }
        public List<SelectListItem> StaffPositions { get; set; }
        public List<SelectListItem> PerevozimieGruzi { get; set; }
        public List<SelectListItem> Avtopark { get; set; }
        public List<SelectListItem> Zakaz1 { get; set; }
        public List<SelectListItem> Zakaz2 { get; set; }
        public List<SelectListItem> Zakaz3 { get; set; }
        public List<SelectListItem> Zakaz4 { get; set; }
        public IActionResult OnGet()
        {
            StaffPositions = _context.Positions.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.JobTitle
                }).ToList();
            PerevozimieGruzi = _context.Cargos.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Title
                }).ToList();
            Avtopark = _context.TypesOfCars.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Name
                }).ToList();
            Zakaz1 = _context.Cargos.Select(p =>
              new SelectListItem
              {
                  Value = p.ID.ToString(),
                  Text = p.Title
              }).ToList();
            Zakaz2 = _context.Routes.Select(p =>
             new SelectListItem
             {
                 Value = p.ID.ToString(),
                 Text = p.Customer
             }).ToList();
            Zakaz3 = _context.Routes.Select(p =>
            new SelectListItem
            {
                Value = p.RecordOfThePayment.ToString(),
                Text = p.RecordOfThePayment
            }).ToList();
            Zakaz4 = _context.Routes.Select(p =>
            new SelectListItem
            {
                Value = p.TheMarkOnTheReturn.ToString(),
                Text = p.TheMarkOnTheReturn
            }).ToList();


            return Page();

        }
    }
}