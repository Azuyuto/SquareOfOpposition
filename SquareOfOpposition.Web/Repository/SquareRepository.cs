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
                entity.SentenceA = square.SentenceA;
                entity.SentenceI = square.SentenceI;
                entity.SentenceO = square.SentenceO;
                entity.SentenceE = square.SentenceE;
                entity.States = square.States;
            }

            SaveChanges();
        }
    }
}
