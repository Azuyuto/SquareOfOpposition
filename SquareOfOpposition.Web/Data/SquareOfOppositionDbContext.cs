using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SquareOfOpposition.Web.Models.Domain;
using System.Diagnostics;

namespace SquareOfOpposition.Web.Data
{
    public class SquareOfOppositionDbContext : DbContext
    {
        public SquareOfOppositionDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Square> Squares { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<StateTransition> StateTransitions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<State>()
            //    .HasMany(e => e.InTransitions)
            //    .WithMany(e => e.PickupState)
            //    .UsingEntity<StateTransition>(
            //    e => e.HasOne<State>().WithMany().HasForeignKey(e => e.PickupStateId),
            //    e => e.HasOne<State>().WithMany().HasForeignKey(e => e.DestinationStateId));
            //modelBuilder.Entity<State>()
            //    .HasMany<StateTransition>(g => g.InTransitions)
            //    .WithOne(s => s.PickupState);

            //modelBuilder.Entity<StateTransition>()
            //    .HasOne<State>(s => s.PickupState)
            //    .WithMany(s => s.InTransitions);

            modelBuilder.Entity<StateTransition>()
                 .HasOne(pt => pt.PickupState)
                 .WithMany(p => p.InTransitions) // <--
                 .HasForeignKey(pt => pt.PickupStateId)
                 .OnDelete(DeleteBehavior.Restrict); // see the note at the end

            modelBuilder.Entity<StateTransition>()
                .HasOne(pt => pt.DestinationState)
                .WithMany(t => t.OutTransitions)
                .HasForeignKey(pt => pt.DestinationStateId);
        }
    }
}
