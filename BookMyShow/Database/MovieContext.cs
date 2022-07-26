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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieBooking> MovieBookings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
    }
}
