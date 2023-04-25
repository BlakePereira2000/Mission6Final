using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mission6Final.Models;

namespace Mission6Final.Models
{
    public class MovieContext : DbContext
    {
        // Constructor 
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<AddMovie> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovie>().HasData(

                new AddMovie
                {
                    MovieId = 1,
                    title = "Lion King",
                    year = 2000,
                    director = "bill",
                    rating = "ten",
                    edited = false,
                    lentTo = "none",
                    notes = "none",
                },
                new AddMovie
                {
                    MovieId = 2,
                    title = "Finding Nemo",
                    year = 2000,
                    director = "Nemo",
                    rating = "9",
                    edited = false,
                    lentTo = "none",
                    notes = "none",
                },
                new AddMovie
                {
                    MovieId = 3,
                    title = "Star Wars",
                    year = 2006,
                    director = "Obi",
                    rating = "ten",
                    edited = false,
                    lentTo = "none",
                    notes = "none",
                }
            );
        }
    }
}

