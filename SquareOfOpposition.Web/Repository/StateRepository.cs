using SquareOfOpposition.Web.Data;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Repository
{
    public class StateRepository : GenericRepository<State>, IStateRepository
    {
        public StateRepository(SquareOfOppositionDbContext context) : base(context)
        {

        }
    }
}
