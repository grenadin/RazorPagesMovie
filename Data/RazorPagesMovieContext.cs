using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext //gen by efcofe use scaffold
    {

        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } 
        //DBSet Class used to query and save instance of TEntity. it return result from database 
        //This is Properties
        //It can cut RazorPagesMovie.Models. from this to show only DbSet<Movie>.
        //It think like a folder.

        
    }
}
