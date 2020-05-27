using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using F1CRUD.Data;
using F1CRUD.F1;

namespace F1CRUD.Pages.results
{
    public class DetailsModel : PageModel
    {
        private readonly F1CRUD.Data.F1CRUDContext _context;

        public DetailsModel(F1CRUD.Data.F1CRUDContext context)
        {
            _context = context;
        }

        public Results Results { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Results = await _context.Results
                .Include(r => r.Constructors)
                .Include(r => r.Drivers)
                .Include(r => r.Races)
                .Include(r => r.circuits).FirstOrDefaultAsync(m => m.resultId == id);

            if (Results == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
