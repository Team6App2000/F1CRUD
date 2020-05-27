using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using F1CRUD.Data;
using F1CRUD.F1;

namespace F1CRUD.Pages.constructors
{
    public class DeleteModel : PageModel
    {
        private readonly F1CRUD.Data.F1CRUDContext _context;

        public DeleteModel(F1CRUD.Data.F1CRUDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Constructors Constructors { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Constructors = await _context.Constructors.FirstOrDefaultAsync(m => m.constructorsId == id);

            if (Constructors == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Constructors = await _context.Constructors.FindAsync(id);

            if (Constructors != null)
            {
                _context.Constructors.Remove(Constructors);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
