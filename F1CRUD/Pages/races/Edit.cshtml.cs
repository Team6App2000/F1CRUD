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

namespace F1CRUD.Pages.races
{
    public class EditModel : PageModel
    {
        private readonly F1CRUD.Data.F1CRUDContext _context;

        public EditModel(F1CRUD.Data.F1CRUDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Races Races { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Races = await _context.Races
                .Include(r => r.circuits).FirstOrDefaultAsync(m => m.raceName == id);

            if (Races == null)
            {
                return NotFound();
            }
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

            _context.Attach(Races).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacesExists(Races.raceName))
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

        private bool RacesExists(string id)
        {
            return _context.Races.Any(e => e.raceName == id);
        }
    }
}
