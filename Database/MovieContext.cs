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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<MovieActor>().HasOne(m => m.Movie).WithMany(ma => ma.Movie_Actor).HasForeignKey(mi =>mi.MovieId);

            modelbuilder.Entity<MovieActor>().HasOne(a => a.Actor).WithMany(ma => ma.Movie_Actor).HasForeignKey(mi =>mi.ActorId);

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieBooking> MovieBookings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor>Movie_Actor { get; set; }

    }
}
