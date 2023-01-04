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

        public void AddOrUpdate(Square square)
        {
            if (square.Id == 0)
            {
                // Add
                Add(square);
            }
            else
            {
                // Update
                var entity = GetById(square.Id);
                entity.Name = square.Name;
                entity.SentanceA = square.SentanceA;
                entity.SentanceI = square.SentanceI;
                entity.SenranceO = square.SenranceO;
                entity.SentanceE = square.SentanceE;
                entity.States = square.States;
            }

            SaveChanges();
        }
    }
}
