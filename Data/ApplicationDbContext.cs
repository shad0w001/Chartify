using Chartify.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Chartify.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Chart> Charts { get; set; }
        public DbSet<ChartSet> ChartSets { get; set; }
        public DbSet<ChartsOfSets> ChartsOfSets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D9KIHAL;Database=Chartify;Trusted_Connection=True;TrustServerCertificate=True;");
            //insert your sql server in place of the dot
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ChartsOfSets>().HasNoKey();
            builder.Entity<Chart>().Property(c => c.Duration).HasColumnType("time");
            builder.Seed();
        }
    }
}