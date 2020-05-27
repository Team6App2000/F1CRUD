using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1CRUD.Data;
using F1CRUD.F1;

namespace F1CRUD.Pages.results
{
    public class EditModel : PageModel
    {
        private readonly F1CRUD.Data.F1CRUDContext _context;

        public EditModel(F1CRUD.Data.F1CRUDContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["constructorId"] = new SelectList(_context.Constructors, "constructorsId", "constructorsId");
           ViewData["driverId"] = new SelectList(_context.Drivers, "driverId", "driverId");
           ViewData["raceName"] = new SelectList(_context.Races, "raceName", "raceName");
           ViewData["circuitId"] = new SelectList(_context.Circuits, "circuitId", "circuitId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Results).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultsExists(Results.resultId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ResultsExists(int id)
        {
            return _context.Results.Any(e => e.resultId == id);
        }
    }
}
