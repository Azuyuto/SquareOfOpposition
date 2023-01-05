using SquareOfOpposition.Web.Data;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Repository
{
    public class StateTransitionRepository : GenericRepository<StateTransition>, IStateTransitionRepository
    {
        public StateTransitionRepository(SquareOfOppositionDbContext context) : base(context)
        {

        }

        public void RemoveBySquare(Square square)
        {
            foreach(var state in square.States)
            {
                var stateTransitions = GetMany(a => a.PickupStateId == state.Id || a.DestinationStateId == state.Id);
                if(stateTransitions != null && stateTransitions.Any())
                {
                    RemoveRange(stateTransitions);
                }
            }
            SaveChanges();
        }
    }
}
