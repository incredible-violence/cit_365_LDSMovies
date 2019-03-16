using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkingLDSMovies.Models
{
    public class WorkingLDSMoviesContext : DbContext
    {
        public WorkingLDSMoviesContext (DbContextOptions<WorkingLDSMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<WorkingLDSMovies.Models.Movie> Movie { get; set; }
    }
}
