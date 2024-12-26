using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCFilmes.Models;

namespace MVCFilmes.Data
{
    public class MVCFilmesContext : DbContext
    {
        public MVCFilmesContext (DbContextOptions<MVCFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCFilmes.Models.Filmes> Filmes { get; set; } = default!;
    }
}
