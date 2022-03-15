#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovieUI.Data
{
    public class MvcMovieUIContext : DbContext
    {
        public MvcMovieUIContext (DbContextOptions<MvcMovieUIContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
