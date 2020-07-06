using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;// Actually, It look like Mvc
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel //derived from PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;//Why want this field

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context) //inject 
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync() 
        {
            Movie = await _context.Movie.ToListAsync(); //call list of Movie in db if it has ant movie in the list
        }//This Method OnGet or OnGetAsync called. It's not necessary to return value 
    }
}
