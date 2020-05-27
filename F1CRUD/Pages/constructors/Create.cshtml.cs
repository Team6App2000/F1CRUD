using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using F1CRUD.Data;
using F1CRUD.F1;

namespace F1CRUD.Pages.constructors
{
    public class CreateModel : PageModel
    {
        private readonly F1CRUD.Data.F1CRUDContext _context;

        public CreateModel(F1CRUD.Data.F1CRUDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Constructors Constructors { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Constructors.Add(Constructors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
