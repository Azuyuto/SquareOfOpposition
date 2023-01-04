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
    }
}
