using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Interfaces
{
    public interface IStateTransitionRepository : IGenericRepository<StateTransition>
    {
        void RemoveBySquare(Square square);
    }
}
