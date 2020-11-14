using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BDTransportCompany.Data;
using BDTransportCompany.Models;

namespace BDTransportCompany.Pages.Route
{
    public class CreateModel : PageModel
    {
        private readonly BDTransportCompany.Data.BDTransportCompanyContext _context;

        public CreateModel(BDTransportCompany.Data.BDTransportCompanyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Routes Routes { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Routes.Add(Routes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
