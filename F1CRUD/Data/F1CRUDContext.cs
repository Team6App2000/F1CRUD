using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using F1CRUD.F1;

namespace F1CRUD.Data
{
    public class F1CRUDContext : DbContext
    {
        public F1CRUDContext (DbContextOptions<F1CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<F1CRUD.F1.Drivers> Drivers { get; set; }

        public DbSet<F1CRUD.F1.Constructors> Constructors { get; set; }

        public DbSet<F1CRUD.F1.Circuits> Circuits { get; set; }

        public DbSet<F1CRUD.F1.Races> Races { get; set; }

        public DbSet<F1CRUD.F1.Results> Results { get; set; }
    }
}
