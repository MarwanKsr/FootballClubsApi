
using Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Data
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext>options):base(options)
        {

        }
       public DbSet<Club> Clubs { get; set; }
       public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().Property(x => x.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Club>().HasOne(c => c.Country)
                                        .WithMany(c => c.Clubs)
                                        .HasForeignKey(c => c.CountryId)
                                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Country>().HasData(
                new Country() { Id = 1, Name = "Spain" },
                new Country() { Id = 2, Name = "Germany" },
                new Country() { Id = 3, Name = "England" },
                new Country() { Id = 4, Name = "Turkey" },
                new Country() { Id = 5, Name = "Italy" }
                );
            modelBuilder.Entity<Club>().HasData(
                new Club() { Id = 1, Name = "Barcelona", CountryId = 1, CoachsName = "Xavi Hernandez" },
                new Club() { Id = 2, Name = "Real Madrid", CountryId = 1, CoachsName = "Carlo Ancelotti" },
                new Club() { Id = 3, Name = "Galatasaray", CountryId = 4, CoachsName = "Domènec Torrent" },
                new Club() { Id = 4, Name = "Fenerbahçe", CountryId = 4, CoachsName = "Ersun Yanal" },
                new Club() { Id = 5, Name = "liverpool", CountryId = 3, CoachsName = "Jürgen Klopp" }
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
       
}

