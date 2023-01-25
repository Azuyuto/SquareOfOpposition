using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Interfaces
{
    public interface ISquareService
    {
        void AddOrUpdate(Square square);
        void Remove(int squareId);
    }
}
