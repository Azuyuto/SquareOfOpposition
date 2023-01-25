using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.Services
{
    public class SquareService : ISquareService
    {
        private readonly ISquareRepository _squareRepository;
        private readonly IStateRepository _stateRepository;
        private readonly IStateTransitionRepository _stateTransitionRepository;

        public SquareService(ISquareRepository squareRepository, IStateTransitionRepository stateTransitionRepository, IStateRepository stateRepository)
        {
            _squareRepository = squareRepository;
            _stateTransitionRepository = stateTransitionRepository;
            _stateRepository = stateRepository;
        }

        public void AddOrUpdate(Square square)
        {
            if (square.Id == 0)
            {
                // Add
                _squareRepository.Add(square);
            }
            else
            {
                // Update
                var entity = _squareRepository.GetMany(a => a.Id == square.Id, a => a.States).First();
                if (entity.ParentStateId != square.ParentStateId)
                {
                    _stateTransitionRepository.RemoveBySquare(entity);
                }
                entity.ParentStateId = square.ParentStateId;
                entity.Name = square.Name;
                entity.Color = square.Color;
                entity.SentenceA = square.SentenceA;
                entity.SentenceI = square.SentenceI;
                entity.SentenceO = square.SentenceO;
                entity.SentenceE = square.SentenceE;
                entity.States = square.States;
            }

            _squareRepository.SaveChanges();
        }

        public void Remove(int squareId)
        {
            var states = _stateRepository.GetMany(a => a.SquareId == squareId, a => a.Squares).ToList();
            foreach (var state in states)
            {
                foreach(var sq in state.Squares)
                {
                    Remove(sq.Id);
                }
            }
            var square = _squareRepository.GetMany(a => a.Id == squareId, a => a.States).First();
            _stateTransitionRepository.RemoveBySquare(square);
            _squareRepository.Remove(square);
            _squareRepository.SaveChanges();
        }
    }
}
