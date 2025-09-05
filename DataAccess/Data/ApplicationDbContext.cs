using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverCompetition> DriverCompetitions { get; set; }
        public DbSet<FastLap> FastLaps { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DRIVERS
            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Country)
                .WithMany()
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.Restrict); // Evita ON DELETE CASCADE

            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Stats)
                .WithMany()
                .HasForeignKey(d => d.StatsId)
                .OnDelete(DeleteBehavior.Restrict);

            // TEAMS
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Stats)
                .WithMany()
                .HasForeignKey(t => t.StatsId)
                .OnDelete(DeleteBehavior.Restrict);

            // DRIVER COMPETITION
            modelBuilder.Entity<DriverCompetition>()
                .HasOne(dc => dc.Driver)
                .WithMany()
                .HasForeignKey(dc => dc.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DriverCompetition>()
                .HasOne(dc => dc.Competition)
                .WithMany()
                .HasForeignKey(dc => dc.CompetitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DriverCompetition>()
                .HasOne(dc => dc.Team)
                .WithMany()
                .HasForeignKey(dc => dc.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            // RACE
            modelBuilder.Entity<Race>()
                .HasOne(t => t.Country)
                .WithMany()
                .HasForeignKey(t => t.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
