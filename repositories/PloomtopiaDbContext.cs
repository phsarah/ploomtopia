using Microsoft.EntityFrameworkCore;
using Ploomtopia.Models;

namespace Ploomtopia.Repositories
{
    public class PloomtopiaDbContext : DbContext
    {
        public PloomtopiaDbContext(DbContextOptions<PloomtopiaDbContext> options)
            : base(options)
        {}

        public DbSet<Ploomie> Ploomies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ploomie>()
                .HasIndex(p => p.Name);


            base.OnModelCreating(modelBuilder);
        }

    }
}
