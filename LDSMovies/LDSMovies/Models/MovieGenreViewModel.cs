using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSMovies.Models
{
    public class MovieGenreViewModel
    {
        public PaginatedList<Movie> Movies { get; set; }
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
