using Microsoft.EntityFrameworkCore;
using myIMDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCast>()
                .HasOne(b => b.Movie)
                .WithMany(ba => ba.MovieCasts)
                .HasForeignKey(bi => bi.MovieId);

            modelBuilder.Entity<MovieCast>()
              .HasOne(b => b.Actor)
              .WithMany(ba => ba.MovieCasts)
              .HasForeignKey(bi => bi.ActorId);

            
        }


        public DbSet<Actor> Actor { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
    }
}
