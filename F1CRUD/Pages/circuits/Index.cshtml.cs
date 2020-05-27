using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using F1CRUD.Data;
using F1CRUD.F1;

namespace F1CRUD.Pages.circuits
{
    public class IndexModel : PageModel
    {
        private readonly F1CRUD.Data.F1CRUDContext _context;

        public IndexModel(F1CRUD.Data.F1CRUDContext context)
        {
            _context = context;
        }

        public IList<Circuits> Circuits { get;set; }

        public async Task OnGetAsync()
        {
            Circuits = await _context.Circuits.ToListAsync();
        }
    }
}
