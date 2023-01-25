using SquareOfOpposition.Web.Data;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Repository
{
    public class SquareRepository : GenericRepository<Square>, ISquareRepository
    {
        public SquareRepository(SquareOfOppositionDbContext context) : base(context)
        {

        }
    }
}
