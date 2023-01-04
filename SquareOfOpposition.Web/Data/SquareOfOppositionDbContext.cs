using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Data
{
    public class SquareOfOppositionDbContext : DbContext
    {
        public SquareOfOppositionDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Square> Squares { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>()
                .HasMany(e => e.States)
                .WithMany(e => e.StateOf)
                .UsingEntity<StateSet>(
                e => e.HasOne<State>().WithMany().HasForeignKey(e => e.StateId),
                e => e.HasOne<State>().WithMany().HasForeignKey(e => e.DestinationStateId));
        }
    }
}
