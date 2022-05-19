
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
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
       
}

