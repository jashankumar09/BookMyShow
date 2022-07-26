using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Database
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt) : base(opt)
        {

        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieBooking> MovieBooking { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Theatre> Theatre { get; set; }
    }
}
